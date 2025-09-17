using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataSerializers;
using MailKit.Net.Smtp;
using MimeKit;
using System.Configuration;
using MailKit.Net.Imap;
using MailKit;



namespace AlumnoManager

{
    public struct Estudiante
    {
        public string Nombre;
        public int Edad;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public string Genero;
        public List<string> Actividades;
        public string Estado => (Nota1 + Nota2 + Nota3) / 3.0 >= 3.0 ? "Aprobado" : "Reprobado";
        public double Promedio => (Nota1 + Nota2 + Nota3) / 3.0;

    }

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private List<Estudiante> listaEstudiantes = new List<Estudiante>(); //esto es un arreglo para almacenar temporalmente

        private void MainForm_Load(object sender, EventArgs e)
        {
            CargarDatosDesdeCsv();
            ActualizarDataGridView();
            ActualizarListBox();
            
        }

        private void GuardarDatosEnCsv()
        {
            string ruta = Path.Combine(Application.StartupPath, "Data", "students.csv");
            var filas = new List<string[]>();

            foreach (var est in listaEstudiantes)
            {
                filas.Add(new string[]
                {
            est.Nombre,
            est.Edad.ToString(),
            est.Nota1.ToString(CultureInfo.InvariantCulture),
            est.Nota2.ToString(CultureInfo.InvariantCulture),
            est.Nota3.ToString(CultureInfo.InvariantCulture),
            est.Genero,
            string.Join("|", est.Actividades)
                });
            }

            CsvSerializer.GuardarCsv(ruta, filas);
        }

        private void CargarDatosDesdeCsv()
        {
            string ruta = Path.Combine(Application.StartupPath, "Data", "students.csv");
            var filas = CsvSerializer.LeerCsv(ruta);

            listaEstudiantes.Clear();

            foreach (var fila in filas)
            {
                
                var est = new Estudiante
                {
                    Nombre = fila[0],
                    Edad = int.Parse(fila[1]),
                    Nota1 = double.Parse(fila[2], CultureInfo.InvariantCulture),
                    Nota2 = double.Parse(fila[3], CultureInfo.InvariantCulture),
                    Nota3 = double.Parse(fila[4], CultureInfo.InvariantCulture),
                    Genero = fila[5],
                    Actividades = fila[6].Split('|').ToList()
                };

                listaEstudiantes.Add(est);
            }
        }

        private void ActualizarDataGridView() //este metodo limpia el datagridview y lo actualiza con los datos de la lista
        {
            dgvEstudiantes.Rows.Clear();
            dgvEstudiantes.Columns.Clear();
            


            // Definir columnas
            dgvEstudiantes.Columns.Add("Nombre", "Nombre");
            dgvEstudiantes.Columns.Add("Edad", "Edad");
            dgvEstudiantes.Columns.Add("Genero", "Género");
            dgvEstudiantes.Columns.Add("Actividades", "Actividades");
            dgvEstudiantes.Columns.Add("Nota1", "Nota 1");
            dgvEstudiantes.Columns.Add("Nota2", "Nota 2");
            dgvEstudiantes.Columns.Add("Nota3", "Nota 3");
            dgvEstudiantes.Columns.Add("Promedio", "Promedio");
            dgvEstudiantes.Columns.Add("Estado", "Estado");

            // Agregar filas
            foreach (var est in listaEstudiantes)
            {
                double promedio = (est.Nota1 + est.Nota2 + est.Nota3) / 3.0;
                string estado = promedio >= 3.0 ? "Aprobado" : "Reprobado";

                dgvEstudiantes.Rows.Add(est.Nombre, est.Edad, est.Genero, string.Join(", ", est.Actividades), est.Nota1.ToString("0.0", CultureInfo.CurrentCulture), est.Nota2.ToString("0.0", CultureInfo.CurrentCulture), est.Nota3.ToString("0.0", CultureInfo.CurrentCulture), promedio.ToString("0.0", CultureInfo.CurrentCulture), estado);
            }
        } 

        private void ActualizarListBox() //el listBox servira para seleccionar un estudiante y ver sus detalles
        {
            lstNombres.Items.Clear();
            foreach (var est in listaEstudiantes)
            {
                lstNombres.Items.Add(est.Nombre);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // para validar entradas
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                    throw new Exception("El nombre no puede estar vacío.");
                if (!int.TryParse(txtEdad.Text, out int edad))
                    throw new Exception("Edad inválida.");
                if (!double.TryParse(txtNota1.Text, out double nota1) ||
                    !double.TryParse(txtNota2.Text, out double nota2) ||
                    !double.TryParse(txtNota3.Text, out double nota3))
                    throw new Exception("Las notas deben ser numéricas.");

                string genero = rdoMasculino.Checked ? "Masculino" : rdoFemenino.Checked ? "Femenino" : "";

                var actividades = new List<string>();
                if (chkDeportes.Checked) actividades.Add("Deportes");
                if (chkMusica.Checked) actividades.Add("Música");
                if (chkArte.Checked) actividades.Add("Arte");

                // para crear estudiante
                var nuevo = new Estudiante
                {
                    Nombre = txtNombre.Text.Trim(),
                    Edad = edad,
                    Nota1 = nota1,
                    Nota2 = nota2,
                    Nota3 = nota3,
                    Genero = genero,
                    Actividades = actividades
                };

                // esto es para agregar a la lista y guardar
                listaEstudiantes.Add(nuevo);
                GuardarDatosEnCsv();

                // y actualizar interfaz
                ActualizarDataGridView();
                ActualizarListBox();

                MessageBox.Show("Estudiante registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormularioRegistro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarFormularioRegistro() //este metodo limpia los campos del formulario
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            rdoMasculino.Checked = false;
            rdoFemenino.Checked = false;
            chkDeportes.Checked = false;
            chkMusica.Checked = false;
            chkArte.Checked = false;
        }

        private void lstNombres_SelectedIndexChanged(object sender, EventArgs e) //el primer list box
        {
            if (lstNombres.SelectedIndex == -1) return;

            string nombreSeleccionado = lstNombres.SelectedItem.ToString();
            var est = listaEstudiantes.FirstOrDefault(x => x.Nombre == nombreSeleccionado);

            if (!string.IsNullOrEmpty(est.Nombre))
            {
                // para Mostrar detalles 
                lblNombre.Text = est.Nombre;
                lblEdad.Text = est.Edad.ToString();
                lblNota1.Text = est.Nota1.ToString();
                lblNota2.Text = est.Nota2.ToString();
                lblNota3.Text = est.Nota3.ToString();

                // para mostrar las imagenes
                double promedio = (est.Nota1 + est.Nota2 + est.Nota3) / 3.0;
                picEstado.Image = promedio >= 3.0
                    ? Properties.Resources.Aprobado
                    : Properties.Resources.Reprobado;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = txtBuscar.Text.Trim().ToLower();

            List<Estudiante> filtrados;

            if (string.IsNullOrEmpty(criterio))
            {
                // Mostrar mensaje
                MessageBox.Show("Por favor, ingresa un nombre para buscar.");

                // para asignar toda la lista para que aparezca en el DataGridView
                filtrados = listaEstudiantes;
            }
            else
            {
                // Filtrar estudiantes que coincidan con el criterio
                filtrados = listaEstudiantes
                    .Where(est => !string.IsNullOrEmpty(est.Nombre) &&
                                  est.Nombre.ToLower().Contains(criterio))
                    .ToList();
            }

            dgvEstudiantes.Rows.Clear();

            if (filtrados.Count == 0)
            {
                MessageBox.Show("No se encontraron estudiantes con ese nombre.");
                // Limpiar detalles y la imagen
                lblNombre.Text = "-";
                lblEdad.Text = "-";
                lblNota1.Text = "-";
                lblNota2.Text = "-";
                lblNota3.Text = "-";
                picEstado.Image = null;
                return;
            }

            // Mostrar los resultados en el DataGridView
            foreach (var est in filtrados)
            {
                double promedio = (est.Nota1 + est.Nota2 + est.Nota3) / 3.0;
                string estado = promedio >= 3.0 ? "Aprobado" : "Reprobado";

                dgvEstudiantes.Rows.Add(est.Nombre,
                        est.Edad,
                        est.Genero,
                        string.Join(", ", est.Actividades),
                        est.Nota1,
                        est.Nota2,
                        est.Nota3,
                        promedio.ToString("0.0"),
                        estado);

            }

            // Mostrar detalles del primer estudiante filtrado
            var estudianteDetalle = filtrados[0];

            lblNombre.Text = estudianteDetalle.Nombre;
            lblEdad.Text = estudianteDetalle.Edad.ToString();
            lblNota1.Text = estudianteDetalle.Nota1.ToString();
            lblNota2.Text = estudianteDetalle.Nota2.ToString();
            lblNota3.Text = estudianteDetalle.Nota3.ToString();

            double promedioDetalle = (estudianteDetalle.Nota1 + estudianteDetalle.Nota2 + estudianteDetalle.Nota3) / 3.0;
            picEstado.Image = promedioDetalle >= 3.0
                ? Properties.Resources.Aprobado
                : Properties.Resources.Reprobado;
        }

        private void dgvEstudiantes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignorar si se hace clic en encabezado
            if (e.RowIndex < 0) return;

            // Obtener el nombre de la fila seleccionada
            string nombre = dgvEstudiantes.Rows[e.RowIndex].Cells[0].Value?.ToString();

            if (string.IsNullOrEmpty(nombre)) return;

            // Buscar el estudiante en la lista
            var estudianteSeleccionado = listaEstudiantes.FirstOrDefault(est => est.Nombre == nombre);

            // Validar que el estudiante tenga nombre 
            if (string.IsNullOrEmpty(estudianteSeleccionado.Nombre)) return;

            // Preguntar si desea eliminar
            var confirm = MessageBox.Show(
                $"¿Estás seguro de eliminar a {estudianteSeleccionado.Nombre}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                // Eliminar de la lista
                listaEstudiantes.Remove(estudianteSeleccionado);

                // Actualizar interfaz
                ActualizarDataGridView();
                ActualizarListBox();
                GuardarDatosEnCsv();
            }
        
        }

        private bool ValidarCorreo(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                string dominio = addr.Host.ToLower();

                // Lista de dominios permitidos para los correos
                string[] dominiosPermitidos = { "gmail.com", "outlook.com", "hotmail.com", "yahoo.com" };

                if (!dominiosPermitidos.Contains(dominio))
                {
                    MessageBox.Show("Dominio de correo no permitido.");
                    return false;
                }

                return true;
            }
            catch
            {
                MessageBox.Show("Formato de correo inválido.");
                return false;
            }
        }
        private string GenerarCuerpoCorreo(Estudiante est) //este es un metodo para agregar lo q va a ir en el correo
        {
            return $@"
            📋 DATOS DEL ESTUDIANTE

             Nombre: {est.Nombre}
             Edad: {est.Edad}
             Género: {est.Genero}
             Actividades: {string.Join(", ", est.Actividades)}
             Notas: {est.Nota1}, {est.Nota2}, {est.Nota3}
             Promedio: {est.Promedio}
             Estado: {est.Estado}

             ";
        }
        private Estudiante estudianteSeleccionadoCorreo;
        private async void btnEnviarCorreo_Click(object sender, EventArgs e) //este metodo envia el correo
        {
            if (estudianteSeleccionadoCorreo.Nombre == null)
            {
                MessageBox.Show("Selecciona un estudiante antes de enviar el correo.");
                return;
            }

            string emailDestino = txtEmailDestino.Text.Trim();
            if (!ValidarCorreo(emailDestino)) return;

            // en esta parte usamos directamente la variable estudianteSeleccionadoCorreo
            var est = estudianteSeleccionadoCorreo;

            try
            {
                var mensaje = new MimeMessage();
                string correoEmisor = ConfigurationManager.AppSettings["CorreoEmisor"];
                string claveCorreo = ConfigurationManager.AppSettings["ClaveCorreo"];

                mensaje.From.Add(new MailboxAddress("Sistema de Gestión", correoEmisor)); // Remitente
                mensaje.To.Add(new MailboxAddress("", emailDestino)); // Destinatario
                mensaje.Subject = $"Información del estudiante: {est.Nombre}";

                // Crear cuerpo del correo y adjuntar archivo
                var builder = new BodyBuilder();
                builder.TextBody = GenerarCuerpoCorreo(est);
                builder.Attachments.Add("Data\\students.csv");
                mensaje.Body = builder.ToMessageBody();

                using (var cliente = new SmtpClient())
                {
                    // se puede usar smtp4dev o Papercut para pruebas locales
                    await cliente.ConnectAsync("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                    await cliente.AuthenticateAsync(correoEmisor, claveCorreo); // usando App.Config
                    await cliente.SendAsync(mensaje);
                    await cliente.DisconnectAsync(true);
                }

                MessageBox.Show("Correo enviado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar correo: {ex.Message}");
            }
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedTab == tabCorreo)
            {
                lstEstudiantesCorreo.Items.Clear();
                foreach (var est in listaEstudiantes)
                {
                    lstEstudiantesCorreo.Items.Add(est.Nombre);
                }
            }
        }

        

        private void lstEstudiantesCorreo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEstudiantesCorreo.SelectedIndex == -1) return;

            string nombreSeleccionado = lstEstudiantesCorreo.SelectedItem.ToString();
            estudianteSeleccionadoCorreo = listaEstudiantes.FirstOrDefault(x => x.Nombre == nombreSeleccionado);
        }

        //a partir de aqui son eventos para cambiar colores y estilos de los botones y cajas de texto
        private void btnBuscar_MouseEnter(object sender, EventArgs e)
        {
            btnBuscar.BackColor = Color.PaleVioletRed;
        }

        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            btnBuscar.BackColor = Color.LightPink; 
        }

        private void btnRegistrar_MouseEnter(object sender, EventArgs e)
        {
            btnRegistrar.BackColor = Color.PaleVioletRed;
        }

        private void btnRegistrar_MouseLeave(object sender, EventArgs e)
        {
            btnRegistrar.BackColor = Color.LightPink;
        }

        private void btnEnviarCorreo_MouseEnter(object sender, EventArgs e)
        {
            btnEnviarCorreo.BackColor = Color.PaleVioletRed;
        }

        private void btnEnviarCorreo_MouseLeave(object sender, EventArgs e)
        {
            btnEnviarCorreo.BackColor = Color.LightPink;
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEdad.Text, out _))
                txtEdad.BackColor = Color.MistyRose; 
            else
                txtEdad.BackColor = Color.White;
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            txtNombre.BackColor = Color.LightPink;
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            txtNombre.BackColor = Color.White;
        }

        private void txtEdad_Enter(object sender, EventArgs e)
        {
            txtEdad.BackColor = Color.LightPink;
        }

        private void txtEdad_Leave(object sender, EventArgs e)
        {
            txtEdad.BackColor = Color.White;
        }

        private void txtNota1_Enter(object sender, EventArgs e)
        {
            txtNota1.BackColor = Color.LightPink;
        }

        private void txtNota1_Leave(object sender, EventArgs e)
        {
            txtNota1.BackColor = Color.White;
        }

        private void txtNota2_Enter(object sender, EventArgs e)
        {
            txtNota2.BackColor = Color.LightPink;
        }

        private void txtNota2_Leave(object sender, EventArgs e)
        {
            txtNota2.BackColor = Color.White;
        }

        private void txtNota3_Enter(object sender, EventArgs e)
        {
            txtNota3.BackColor = Color.LightPink;
        }

        private void txtNota3_Leave(object sender, EventArgs e)
        {
            txtNota3.BackColor = Color.White;
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            txtBuscar.BackColor = Color.LightPink;
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            txtBuscar.BackColor = Color.White;
        }

        private void txtEmailDestino_Enter(object sender, EventArgs e)
        {
            txtEmailDestino.BackColor = Color.LightPink;
        }

        private void txtEmailDestino_Leave(object sender, EventArgs e)
        {
            txtEmailDestino.BackColor = Color.White;
        }

        // eventos para personalizar los listbox para q se vean mas esteticoss

        private void lstEstudiantesCorreo_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            string text = lstEstudiantesCorreo.Items[e.Index].ToString();

            // Determinar colores
            Color backColor = (e.State & DrawItemState.Selected) == DrawItemState.Selected
                ? Color.LightPink 
                : Color.White; 

            Color textColor = Color.Black;

            // Dibujar fondo
            using (SolidBrush brush = new SolidBrush(backColor))
                e.Graphics.FillRectangle(brush, e.Bounds);

            // Medir el tamaño del texto
            SizeF textSize = e.Graphics.MeasureString(text, e.Font);

            // Calcular posición para centrar
            float x = e.Bounds.Left + (e.Bounds.Width - textSize.Width) / 2;
            float y = e.Bounds.Top + (e.Bounds.Height - textSize.Height) / 2;

            // Dibujar texto centrado
            using (SolidBrush textBrush = new SolidBrush(textColor))
                e.Graphics.DrawString(text, e.Font, textBrush, x, y);

            // Dibujar borde inferior
            e.Graphics.DrawLine(Pens.LightGray, e.Bounds.Left, e.Bounds.Bottom - 1, e.Bounds.Right, e.Bounds.Bottom - 1);

        }

        private void lstNombres_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            string text = lstNombres.Items[e.Index].ToString();

            // Determinar colores
            Color backColor = (e.State & DrawItemState.Selected) == DrawItemState.Selected
                ? Color.LightPink 
                : Color.White; 

            Color textColor = Color.Black;

            // Dibujar fondo
            using (SolidBrush brush = new SolidBrush(backColor))
                e.Graphics.FillRectangle(brush, e.Bounds);

            // Medir el tamaño del texto
            SizeF textSize = e.Graphics.MeasureString(text, e.Font);

            // Calcular posición para centrar
            float x = e.Bounds.Left + (e.Bounds.Width - textSize.Width) / 2;
            float y = e.Bounds.Top + (e.Bounds.Height - textSize.Height) / 2;

            // Dibujar texto centrado
            using (SolidBrush textBrush = new SolidBrush(textColor))
                e.Graphics.DrawString(text, e.Font, textBrush, x, y);

            // Dibujar borde inferior
            e.Graphics.DrawLine(Pens.LightGray, e.Bounds.Left, e.Bounds.Bottom - 1, e.Bounds.Right, e.Bounds.Bottom - 1);


        }

        // eventos para recibir correos usando IMAP y MailKit

        private async void btnRecibirCorreo_Click(object sender, EventArgs e)
        {
            try
            {
                lstCorreosRecibidos.Items.Clear();

                // Conectar al servidor IMAP de Gmail (puedes cambiarlo si usas otro)
                using (var client = new ImapClient())
                {
                    await client.ConnectAsync("imap.gmail.com", 993, true);

                    // Autenticación con tu correo y contraseña o App Password
                    await client.AuthenticateAsync("tu_correo@gmail.com", "tu_Contraseña");

                    // Seleccionamos la bandeja de entrada
                    var inbox = client.Inbox;
                    await inbox.OpenAsync(FolderAccess.ReadOnly);

                    // Cargar últimos 5 correos
                    int count = inbox.Count;
                    int start = Math.Max(0, count - 5);

                    for (int i = start; i < count; i++)
                    {
                        var message = await inbox.GetMessageAsync(i);
                        lstCorreosRecibidos.Items.Add($"{message.Date.LocalDateTime} - {message.Subject}");
                    }

                    await client.DisconnectAsync(true);
                }

                MessageBox.Show("Correos recibidos correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al recibir correos: {ex.Message}");
            }
        }

        private async void lstCorreosRecibidos_DoubleClick(object sender, EventArgs e)
        {
            int index = lstCorreosRecibidos.SelectedIndex;
            if (index < 0) return;

            try
            {
                using (var client = new ImapClient())
                {
                    await client.ConnectAsync("imap.gmail.com", 993, true);
                    await client.AuthenticateAsync("tu_correo@gmail.com", "tu_contraseña");

                    var inbox = client.Inbox;
                    await inbox.OpenAsync(FolderAccess.ReadOnly);

                    int count = inbox.Count;
                    int start = Math.Max(0, count - 5);

                    var message = await inbox.GetMessageAsync(start + index);

                    MessageBox.Show($"De: {message.From}\nAsunto: {message.Subject}\n\n{message.TextBody}",
                        "Detalle del Correo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el correo: {ex.Message}");
            }
        }

        // eventos para cambiar colores del boton recibir correo
        private void btnRecibirCorreo_MouseEnter(object sender, EventArgs e)
        {
            btnRecibirCorreo.BackColor = Color.PaleVioletRed;

        }

        private void btnRecibirCorreo_MouseLeave(object sender, EventArgs e)
        {
            btnRecibirCorreo.BackColor = Color.LightPink;
        }
    }
    
}
