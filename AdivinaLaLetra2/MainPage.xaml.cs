using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;


namespace AdivinaLaLetra2
{

    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    
    public partial class MainPage : ContentPage
    {
       
        public static string ranS = RandomString();
        Label labelResult = new Label();
        List<char> termsList = new List<char>();
        List<Button> GridButtons = new List<Button>();
        public string OldBtnName;

        public MainPage()
        {
            InitializeComponent();
            Lisbuttons();
        }


        public void Lisbuttons() {
           

            {
                GridButtons.Add(LetterBtn1); GridButtons.Add(LetterBtn13);
                GridButtons.Add(LetterBtn2); GridButtons.Add(LetterBtn14);
                GridButtons.Add(LetterBtn3); GridButtons.Add(LetterBtn15);
                GridButtons.Add(LetterBtn4); GridButtons.Add(LetterBtn16);
                GridButtons.Add(LetterBtn5); GridButtons.Add(LetterBtn17);
                GridButtons.Add(LetterBtn6); GridButtons.Add(LetterBtn18);
                GridButtons.Add(LetterBtn7); GridButtons.Add(LetterBtn19);
                GridButtons.Add(LetterBtn8); GridButtons.Add(LetterBtn20);
                GridButtons.Add(LetterBtn9); GridButtons.Add(LetterBtn21);
                GridButtons.Add(LetterBtn10); GridButtons.Add(LetterBtn22);
                GridButtons.Add(LetterBtn11); GridButtons.Add(LetterBtn23);
                GridButtons.Add(LetterBtn12); GridButtons.Add(LetterBtn24);
            }
        }
        
        public static string Shuffle(string str)// metodo que reordena aletoriamente la cadema
        {
            char[] array = str.ToCharArray();
            try
            {
               
                Random rng = new Random();
                int n = array.Length;
                while (n > 1)
                {
                    n--;
                    int k = rng.Next(n + 1);
                    var value = array[k];
                    array[k] = array[n];
                    array[n] = value;
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return new string(array);
        }


        static string RandomString()
        {

            List<string> randStr = new List<string>();
            try
            {
                Random random = new Random();
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                
                for (int i = 0; i <= 11; i++)
                {
                    string AlphaRandom = new string(Enumerable.Repeat(chars, 1)
                      .Select(s => s[random.Next(s.Length)]).ToArray());

                    if (randStr.Contains(AlphaRandom))
                    {
                        i--;
                    }
                    else
                    {
                        randStr.Add(AlphaRandom);
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            string rs = string.Join("", randStr.ToArray());
            return Shuffle(rs + rs);
        }
        void ShowVar(int c, System.Object sender)// método para mostrar la letra asignada al boton y poner el boton de color naranja
        {
            try
            {
                (sender as Button).Text = char.ToString(ranS[c]);
                (sender as Button).Style = orangeButton;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        void ShowBlankButton(System.Object sender) // vuelve el botón de colo blanco y oculta la letra asignada
        {
            try
            {
                (sender as Button).Text = "";
                (sender as Button).Style = plainButton;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        Style orangeButton = new Style(typeof(Button))// style para onfigurar botones de color naranja
        {
            Setters =
                {
                      new Setter { Property = Button.BackgroundColorProperty, Value = Color.FromHex ("#E8AD00") },
                      new Setter { Property = Button.TextColorProperty, Value = Color.White },
                      new Setter { Property = Button.BorderRadiusProperty, Value = 0 },
                      new Setter { Property = Button.FontSizeProperty, Value = 25 }

                }
        };

        Style plainButton = new Style(typeof(Button)) // style para configurar botones de color blanco
        {
            Setters = {
                      new Setter { Property = Button.BackgroundColorProperty, Value = Color.FromHex ("#eee") },
                      new Setter { Property = Button.TextColorProperty, Value = Color.Black },
                      new Setter { Property = Button.BorderRadiusProperty, Value = 0 },
                      new Setter { Property = Button.FontSizeProperty, Value = 15 }
                    }
        };


        public void Grid1()
        {
            //Implementación de grid

            try
            {
             
                Grid controlGrid  = new Grid{ RowSpacing = 1, ColumnSpacing = 1 };
     
                controlGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                controlGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                controlGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                controlGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                controlGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

                controlGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                controlGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                controlGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                controlGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                controlGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

                controlGrid.Children.Add(new Button { Text = "", Style = plainButton }, 0, 1);
                controlGrid.Children.Add(new Button { Text = "", Style = plainButton }, 1, 1);
                controlGrid.Children.Add(new Button { Text = "", Style = plainButton }, 2, 1);
                controlGrid.Children.Add(new Button { Text = "", Style = plainButton }, 3, 1);
                controlGrid.Children.Add(new Button { Text = "", Style = plainButton }, 4, 1);
                controlGrid.Children.Add(new Button { Text = "", Style = plainButton }, 0, 2);
                controlGrid.Children.Add(new Button { Text = "", Style = plainButton }, 1, 2);
                controlGrid.Children.Add(new Button { Text = "", Style = plainButton }, 2, 2);
                controlGrid.Children.Add(new Button { Text = "", Style = plainButton }, 3, 2);
                controlGrid.Children.Add(new Button { Text = "", Style = plainButton }, 4, 2);
                controlGrid.Children.Add(new Button { Text = "", Style = plainButton }, 0, 3);
                controlGrid.Children.Add(new Button { Text = "", Style = plainButton }, 1, 3);
                controlGrid.Children.Add(new Button { Text = "", Style = plainButton }, 2, 3);
                controlGrid.Children.Add(new Button { Text = "", Style = plainButton }, 3, 3);
                controlGrid.Children.Add(new Button { Text = "", Style = plainButton }, 4, 3);
                controlGrid.Children.Add(new Button { Text = "", Style = plainButton }, 0, 4);
                controlGrid.Children.Add(new Button { Text = "", Style = plainButton }, 1, 4);
                controlGrid.Children.Add(new Button { Text = "", Style = plainButton }, 2, 4);
                controlGrid.Children.Add(new Button { Text = "", Style = plainButton }, 3, 4);
                controlGrid.Children.Add(new Button { Text = "", Style = plainButton }, 4, 4);
                controlGrid.Children.Add(new Button { Text = "", Style = plainButton }, 0, 5);
                controlGrid.Children.Add(new Button { Text = "", Style = plainButton }, 1, 5);
                controlGrid.Children.Add(new Button { Text = "", Style = plainButton }, 2, 5);
                controlGrid.Children.Add(new Button { Text = "", Style = plainButton }, 3, 5);
                controlGrid.Children.Add(new Button { Text = "", Style = plainButton }, 4, 5);
                Content = controlGrid;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        
        void Button_Clicked(System.Object sender, System.EventArgs e)// evento button_clicked
            {


            try
            {
                var button = (Button)sender;
                string classId = button.ClassId;// se declara variable local que muestra el classId
                string name = button.AutomationId.ToString();// se declara variable local que muestra automationId
               
                int c = Int32.Parse(classId);//convierte el classId tipo string a int32
                ShowVar(c,(sender as Button));// se asigna la la letra al boton segun su classId
               
                


               if (termsList.Count.Equals(0))// el primer botón seleccionado
                {
                    
                    termsList.Add(ranS[c]);// se adiere la letra que se le asignó al botón a una lista para luego compararla con la del siguiente botón
                    OldBtnName = name;// el 
                }
                else if (termsList.Last().Equals(ranS[c])) // si la letra del primer botón asignado coincide con el segundo
                {
                    
                    (sender as Button).IsEnabled = false;
                    foreach (var item in GridButtons)
                    {
                        if (item.AutomationId.Equals(OldBtnName))
                        {
                            item.IsEnabled = false;
                        }
                    }
                    OldBtnName = null; // limpiada OldbtnName para que no quite la coincidencia
                }
                else{ // si no coinciden
                    foreach (var item in GridButtons) 
                    {
                        if (item.AutomationId.Equals(OldBtnName))
                        {
                            ShowBlankButton(item);// se oculta el primer botón
                            termsList.Add(ranS[c]);// se adiere la letra que se le asignó al botón a una lista para luego compararla con la del siguiente botón
                           
                        }
                    }
                    OldBtnName = name;//guarda el AutomationId del último botón usado
                }
      
         
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

    }
}


