namespace SpellcheckRedraw;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void autoTextCorrectionToggle_Toggled(object sender, ToggledEventArgs e)
    {
        // Handle the toggle switch state change here
        bool isToggled = e.Value;

        NoteEditor.Focus();

        // Do something based on the state (isToggled)
        NoteEditor.IsTextPredictionEnabled = isToggled;
        NoteEditor.IsSpellCheckEnabled = isToggled;

        if (isToggled == true)
            NoteEditor.Keyboard = Keyboard.Default;
        else
            NoteEditor.Keyboard = Keyboard.Email;

        //TODO: We need to trigger a refresh by resetting the contents of the editor 
        // Issue re: refresh/repaint of the Editor when toggling on/off
        // https://github.com/dotnet/maui/issues/16894
    }

}

