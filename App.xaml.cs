using otacoS5.Clases;

namespace otacoS5
{
    public partial class App : Application
    {
        public static Clases.PersonRepository personRepo {  get; set; }
        public App(PersonRepository Personrepository)
        {
            InitializeComponent();
            personRepo = Personrepository;
        }
  

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new Vistas.vPersona());
        }
    }
}