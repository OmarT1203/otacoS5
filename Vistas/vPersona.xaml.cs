using otacoS5.Modelos;

namespace otacoS5.Vistas;

public partial class vPersona : ContentPage
{
	public vPersona()
	{
		InitializeComponent();
	}

    private void btnAgregar_Clicked(object sender, EventArgs e)
    {
        lblMnesaje.Text = "";
        App.personRepo.AddNewPerson(txtPersona.Text);
        lblMnesaje.Text = App.personRepo.mensaje;
    }

    private void btnListar_Clicked(object sender, EventArgs e)
    {
        lblMnesaje.Text = "";
        List<Persona> person = App.personRepo.GetAllPeople();
        listaPersonas.ItemsSource = person;
    }
}