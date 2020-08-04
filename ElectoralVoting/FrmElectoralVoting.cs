using ElectoralVoting.Services;
using System;
using System.Windows.Forms;

namespace ElectoralVoting
{
    public partial class FrmElectoralVoting : Form
    {
        private ElectoralVotingService _electoralService;
        private ScreenService _screenService;

        public FrmElectoralVoting()
        {
            InitializeComponent();

            _electoralService = new ElectoralVotingService();
            _screenService = new ScreenService(_electoralService);
            RefreshComponentsTabRegister();
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            openFileImage.ShowDialog();
            string image = openFileImage.FileName;
            _electoralService.AddImage(image);
            picPhotoRegister.ImageLocation = image;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string errors = _electoralService.AddCandidate(txtNameRegister.Text, txtNumberRegister.Text);
            if (!string.IsNullOrEmpty(errors))
                MessageBox.Show(errors);
            else
            {
                MessageBox.Show("Cadastrado com sucesso!");
                RefreshComponentsTabRegister();
            }
        }

        private void btnFinishRegister_Click(object sender, EventArgs e)
        {
            string validation = _electoralService.ValidationRegisterFinish();
            if (validation != "")
            {
                MessageBox.Show(validation);
                return;
            }
            tabControl.TabPages.Add(tabVote);
            tabControl.TabPages.Remove(tabRegister);
            cboCandidates.DataSource = _screenService.GetCandidatesNamesNumbers();
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            _electoralService.ComputeVote(_screenService.CandidateIndex);
            MessageBox.Show("Voto computado!");
        }

        private void btnFinishVote_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Add(tabResult);
            tabControl.TabPages.Remove(tabVote);
            _electoralService.CalculateVotes();
            foreach (var item in _electoralService.CandidateDatas)
            {
                dtgResult.Rows.Add(item.Name, item.Vote, item.PercVote.ToString("F1"));
            }
            _screenService.DefineIndex(_electoralService.CandidateWithMoreVote());
            RefreshComponentsTabResult();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            _screenService.DecreaseIndex();
            RefreshComponentsTabVote();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            _screenService.IncreaseIndex();
            RefreshComponentsTabVote();
        }

        private void cboCandidates_SelectedIndexChanged(object sender, EventArgs e)
        {
            _screenService.DefineIndex(cboCandidates.SelectedIndex);
            RefreshComponentsTabVote();
        }

        private void dtgResult_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _screenService.DefineIndex(e.RowIndex);
            RefreshComponentsTabResult();
        }

        private void FrmElectoralVoting_Load(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tabVote);
            tabControl.TabPages.Remove(tabResult);
        }

        private void RefreshComponentsTabRegister()
        {
            txtNameRegister.Clear();
            txtNumberRegister.Clear();
            string image = _screenService.GetRandomImage();
            _electoralService.AddImage(image);
            picPhotoRegister.ImageLocation = image;
        }

        private void RefreshComponentsTabVote()
        {
            _screenService.SelectCandidate();
            lblName.Text = _screenService.CandidateName;
            lblNumber.Text = _screenService.CandidateNumber;
            picPhotoVt.ImageLocation = _screenService.CandidateImage;
        }

        private void RefreshComponentsTabResult()
        {
            _screenService.SelectCandidate();
            lblNameResult.Text = "Nome: " + _screenService.CandidateName;
            lblNumberResult.Text = "Número: " + _screenService.CandidateNumber;
            lblPercVote.Text = "Votos: " + _screenService.CandidatePerctVote + "%";
            picPhotoResult.ImageLocation = _screenService.CandidateImage;
        }
    }
}
