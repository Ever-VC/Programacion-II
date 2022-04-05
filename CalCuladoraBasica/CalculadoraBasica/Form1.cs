namespace CalculadoraBasica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)//Evento al dar click en el bot�n "Salir"
        {
            Application.Exit();//Salir
        }

        private void Form1_Load(object sender, EventArgs e)//�ste evento sucede al inicar la aplicaci�n (Es lo primero que se ejecutar�)
        {
            cmboOpciones12.Items.Clear();//Limpia la lista al iniciar la aplicaci�n
            cmboOpciones12.Items.Add("Sumar");//Agrega la opci�n de sumar a la lista
            cmboOpciones12.Items.Add("Restar");//Agrega la opci�n de restar a la lista


            listBoxOpciones34.Items.Clear();//Limpia la lista al iniciar la aplicaci�n
            listBoxOpciones34.Items.Add("Multiplicar");//Agrega la opci�n de multiplicar a la lista
            listBoxOpciones34.Items.Add("Dividir");//Agrega la opci�n de dividir a la lista

            cmboOpciones12.Enabled = false;
            listBoxOpciones34.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)//Al dar click en "Calcular" se har� lo siguiente:
        {
            double n1,n2,resultado;
            string aux1, aux2;


            aux1 = txtBoxNum1.Text;
            aux2 = txtBoxNum2.Text;

            if(aux1.Length != 0 && aux2.Length != 0)
            {
                n1 = Convert.ToDouble(aux1);
                n2 = Convert.ToDouble(aux2);
                if (cmboOpciones12.Enabled)//Verifica si el bot�n est� selecionado
                {
                    if (cmboOpciones12.SelectedItem.ToString() =="Sumar")//Verifica la opci�n seleccionada por parte del usuario
                    {
                        resultado = n1 + n2;
                        MessageBox.Show(resultado.ToString());//Hay que convertir a tipo "string" el resultado para mostrarlo al usuario
                    }
                    else if (cmboOpciones12.SelectedItem.ToString() =="Restar")//Verifica la opci�n seleccionada por parte del usuario
                    {
                        resultado = n1 - n2;
                        MessageBox.Show(resultado.ToString());//Hay que convertir a tipo "string" el resultado para mostrarlo al usuario
                    }
                }
                else if (listBoxOpciones34.Enabled)//Si el bot�n anterior no est� seleccionado, verifica si el otro s�
                {
                    if (listBoxOpciones34.SelectedItem.ToString()=="Multiplicar")//Verifica la opci�n seleccionada por parte del usuario
                    {
                        resultado = n1 * n2;
                        MessageBox.Show(resultado.ToString());//Hay que convertir a tipo "string" el resultado para mostrarlo al usuario
                    }
                    else if (listBoxOpciones34.SelectedItem.ToString()=="Dividir")
                    {
                        resultado = n1 / n2;
                        MessageBox.Show(resultado.ToString());//Hay que convertir a tipo "string" el resultado para mostrarlo al usuario
                    }
                }
                else
                {
                    MessageBox.Show("POR FAVOR SELECCIONE UNA OPERACI�N PARA EJECUTAR");
                }
            }
            else
            {
                MessageBox.Show("INSERTE UN DATO PARA OPERAR");
            }

        }

        private void rbtnOpciones12_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnOpciones12.Checked)//Si el bot�n de cheque 1 est� selecionado
            {
                cmboOpciones12.Enabled = true;//Se habilitan las opciones 1 y 2, osea sumar y restar
            }
            else
            {
                cmboOpciones12.Enabled = false;//Sino se mantendr� desabilitado
            }
        }

        private void rbtnOpciones34_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnOpciones34.Checked)//Si el bot�n de cheque 2 est� selecionado
            {
                listBoxOpciones34.Enabled = true;//Se habilitan las opciones 3 y 4, osea �multiplicar y dividir
            }
            else
            {
                listBoxOpciones34.Enabled= false;
            }
        }
    }
}