using System.Windows.Forms;

namespace MinecraftPortalsDatabase
{
    partial class FormMain : Form
    {
        private Form _activeForm;

        public FormMain()
        {
            InitializeComponent();
            OnSelectAnotherWorld();
        }

        private void OpenChildForm(Form childForm)
        {
            _activeForm?.Close();
            _activeForm = childForm;

            _activeForm.BackColor = BackColor;
            _activeForm.TopLevel = false;
            _activeForm.FormBorderStyle = FormBorderStyle.None;
            _activeForm.Dock = DockStyle.Fill;

            Controls.Clear();
            Controls.Add(_activeForm);

            _activeForm.Show();
        }

        private void OnWorldSelected(FormDatabaseWorlds sender, string worldName)
        {
            sender.WorldSelected -= OnWorldSelected;

            var form = new FormDatabasePortals(worldName);
            form.SelectAnotherWorld += OnSelectAnotherWorld;

            OpenChildForm(form);
        }

        private void OnSelectAnotherWorld()
        {
            var form = new FormDatabaseWorlds();
            form.WorldSelected += OnWorldSelected;

            OpenChildForm(form);
        }
    }
}
