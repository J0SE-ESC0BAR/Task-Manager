using OrganizadorJAEM.Forms;
using OrganizadorJAEM.Scraper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace OrganizadorJAEM
{
    public partial class Prinsipal : Form
    {
        private static string cadenaConexion;
        public string mensajeCarga;
        private List<Estudiante> listaEstudiantes = new List<Estudiante>();
        private List<Tutor> listaTutores = new List<Tutor>();
        private List<Forms.Tarea> tareasPendientes = new List<Forms.Tarea>();
        private List<PagoTarea> pagosTareas = new List<PagoTarea>();
        private List<PagoTutor> pagosTutores = new List<PagoTutor>();
        private TareasScraping TS;

        private int idSeleccionado = -1;

        public Prinsipal()
        {
            //Prinsipal.cadenaConexion = cadenaConexion;
            InitializeComponent();
            Terminal("Inicializando programa");
            //CargarEstudiantes();
            CargarDatos();
        }

        private void CargarDatos()
        {
            btn_ScrapearTareas_Click(this, EventArgs.Empty);
            //Terminal("Cargando tareas");
            //CargarTareasPendientes();
            //CargarPagosTareas();
            //CargarPagosTutores();
            //CargarTareas_dataGridVew();
            Terminal("Cargando tareas", "Carga completa");
            //cB_Tutor.SelectedIndex = 0;
            //cB_Estudiante.SelectedIndex = 0;
            //cB_ScraperEstudiante.SelectedIndex = 0;
            txB_DiaHoy.Text = DateTime.Now.ToString("dd");
            lbl_Dia.Text = DateTime.Now.ToString("ddd");
        }
        private void Terminal(string message)
        {
            // Añadir el mensaje seguido de un salto de línea
            rTB_Console.AppendText($"{message}\n");

            // Asegurarte de que el nuevo mensaje esté visible
            rTB_Console.SelectionStart = rTB_Console.Text.Length;
            rTB_Console.ScrollToCaret();
        }
        private void Terminal(string oldMessage, string newMessage)
        {
            int index = rTB_Console.Text.LastIndexOf(oldMessage);
            if (index >= 0) // Si se encuentra el mensaje
            {
                rTB_Console.Select(index, oldMessage.Length);
                rTB_Console.SelectedText = $"{newMessage}";
            }
            else
            {
                // Si no se encuentra el mensaje anterior, simplemente agrega el nuevo mensaje
                Terminal(newMessage);
            }
        }

        //private void CargarEstudiantes()
        //{
        //    // Simulación en memoria sin BD:
        //    listaEstudiantes = new List<Estudiante>()
        //        {
        //            new Estudiante("Nombre 1", "1111"),
        //            new Estudiante("Nombre 2", "2222")
        //        };
        //    foreach (var estudiante in listaEstudiantes)
        //    {
        //        cB_Estudiante.Items.Add(estudiante.Nombre);
        //        //cB_ScraperEstudiante.Items.Add(estudiante.Nombre);
        //    }
        //}



        private void CargarTareasPendientes()
        {
            try
            {
                tareasPendientes = Forms.Tarea.TraerTareasPendientes(cadenaConexion);
            }
            catch (Exception ex)
            {
                Terminal("Error al cargar las tareas pendientes: " + ex.Message);
            }
        }

        private void CargarPagosTareas()
        {
            try
            {
                pagosTareas = PagoTarea.ObtenerPagosTarea(cadenaConexion);
            }
            catch (Exception ex)
            {
                Terminal("Error al cargar los pagos de tareas: " + ex.Message);
            }
        }

        private void CargarPagosTutores()
        {
            try
            {
                pagosTutores = PagoTutor.ObtenerPagosTutor(cadenaConexion);
            }
            catch (Exception ex)
            {
                Terminal("Error al cargar los pagos de tutores: " + ex.Message);
            }
        }
        //private void CargarTareas_dataGridVew()
        //{
        //    try
        //    {
        //        // Crear un DataTable y agregar las columnas que quieres mostrar en el DataGridView
        //        DataTable dataTable = new DataTable();
        //        dataTable.Columns.Add("Id_Tarea", typeof(int));
        //        dataTable.Columns.Add("Estudiante", typeof(string));
        //        dataTable.Columns.Add("Tutor", typeof(string));
        //        dataTable.Columns.Add("Tema", typeof(string));
        //        dataTable.Columns.Add("Descripcion", typeof(string));
        //        dataTable.Columns.Add("Vence", typeof(string));

        //        // Agregar las filas al DataTable con los datos de las tareas pendientes
        //        foreach (Forms.Tarea tarea in tareasPendientes)
        //        {
        //            DataRow row = dataTable.NewRow();
        //            row["Id_Tarea"] = tarea.Id_Tarea;
        //            row["Estudiante"] = "ObtenerNombreEstudiante((int)tarea.Id_Estudiante)";
        //            row["Tutor"] = "ObtenerNombreTutor((int)tarea.Id_Tutor)";
        //            row["Tema"] = tarea.Tema;
        //            row["Descripcion"] = tarea.Descripcion;
        //            row["Vence"] = tarea.Vencimiento.ToString("M");
        //            dataTable.Rows.Add(row);
        //        }
        //        // Asignar el DataTable al DataGridView
        //        dGV_TareasProgramadas.DataSource = dataTable;

        //        // Ocultar la columna "Id_Tarea" (asumiendo que tiene el índice correcto)
        //        dGV_TareasProgramadas.Columns["Id_Tarea"].Visible = false;
        //        // Tamaño de las columnas (puedes agregar aquí el código para ajustar el tamaño de las columnas)
        //        dGV_TareasProgramadas.RowTemplate.Height = 35;

        //        dGV_TareasProgramadas.Columns["Estudiante"].Width = 110;
        //        dGV_TareasProgramadas.Columns["Tutor"].Width = 110;
        //        dGV_TareasProgramadas.Columns["Tema"].Width = 100;
        //        dGV_TareasProgramadas.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //        dGV_TareasProgramadas.Columns["Vence"].Width = 110;
        //    }
        //    catch (Exception ex)
        //    {
        //        // Error de conexión o consulta SQL
        //        Terminal("Error: " + ex.Message);
        //    }
        //}

        private string ObtenerNombreEstudiante(int idEstudiante)
        {
            // Buscar el nombre del estudiante en la lista de estudiantes usando su ID
            Estudiante estudiante = listaEstudiantes.FirstOrDefault(e => e.Id == idEstudiante);
            return estudiante != null ? estudiante.Nombre : "";
        }

        private string ObtenerNombreTutor(int idTutor)
        {
            // Buscar el nombre del tutor en la lista de tutores usando su ID
            Tutor tutor = listaTutores.FirstOrDefault(t => t.Id == idTutor);
            return tutor != null ? tutor.Nombre : "";
        }


        private void Buscar_Click(object sender, EventArgs e)
        {
            Buscar.Text = string.Empty;
        }

        private void Buscar_Leave(object sender, EventArgs e)
        {
            Buscar.Text = "Buscar";
        }

        //private void ckB_TareaTerminada_MouseEnter(object sender, EventArgs e)
        //{
        //    if (ckB_TareaTerminada.Checked == true)
        //    {
        //        ckB_TareaTerminada.Checked = false;
        //    }
        //    else
        //    {
        //        ckB_TareaTerminada.Checked = true;
        //    }
        //}
        //private void ckB_TareaEntregada_MouseEnter(object sender, EventArgs e)
        //{
        //    if (ckB_TareaEntregada.Checked == true)
        //    {
        //        ckB_TareaEntregada.Checked = false;
        //    }
        //    else
        //    {
        //        ckB_TareaEntregada.Checked = true;
        //    }
        //}
        //private void ckB_TutorPagado_MouseEnter(object sender, EventArgs e)
        //{
        //    if (ckB_TutorPagado.Checked == true)
        //    {
        //        ckB_TutorPagado.Checked = false;
        //    }
        //    else
        //    {
        //        ckB_TutorPagado.Checked = true;
        //    }
        //}
        private int rowIndexUnderMouse = -1;
        private int selectedRowCount = 0;

        //private void dGV_TareasProgramadas_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        //{

        //    if (e.RowIndex >= 0)
        //    {
        //        DataGridViewRow row = dGV_TareasProgramadas.Rows[e.RowIndex];
        //        rowIndexUnderMouse = e.RowIndex;

        //        if (selectedRowCount > 1)
        //        {
        //            foreach (DataGridViewRow selectedRow in dGV_TareasProgramadas.SelectedRows)
        //            {
        //                if (selectedRow.Index != rowIndexUnderMouse)
        //                {
        //                    selectedRow.Selected = false;
        //                }
        //            }
        //        }
        //        else if (selectedRowCount == 1 && !row.Selected)
        //        {
        //            dGV_TareasProgramadas.ClearSelection();
        //            row.Selected = true;
        //        }
        //        else
        //        {
        //            row.Selected = true;
        //        }
        //    }
        //}
        //private void dGV_TareasProgramadas_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        //{

        //    if (e.RowIndex >= 0 && e.RowIndex != rowIndexUnderMouse)
        //    {
        //        DataGridViewRow row = dGV_TareasProgramadas.Rows[e.RowIndex];

        //        if (row.Selected && selectedRowCount > 1)
        //        {
        //            row.Selected = false;
        //        }
        //    }
        //}

        //private void dGV_TareasProgramadas_SelectionChanged(object sender, EventArgs e)
        //{
        //    selectedRowCount = dGV_TareasProgramadas.SelectedRows.Count;
        //    // Verificar si hay alguna fila seleccionada
        //    if (dGV_TareasProgramadas.SelectedRows.Count > 0)
        //    {
        //        // Obtener el valor de la celda "Id_Tarea" de la fila seleccionada
        //        int idTarea = Convert.ToInt32(dGV_TareasProgramadas.SelectedRows[0].Cells["Id_Tarea"].Value);
        //        // Almacenar el valor en la variable idSeleccionado
        //        idSeleccionado = idTarea;
        //        EditarTareaRapido(idSeleccionado);
        //    }
        //    else
        //    {
        //        // Si no hay filas seleccionadas, asignar -1 a idSeleccionado
        //        idSeleccionado = -1;
        //    }
        //}
        //private void ckB_TareaPagada_MouseEnter(object sender, EventArgs e)
        //{
        //    if (ckB_TareaPagada.Checked == true)
        //    {
        //        Thread.Sleep(100);
        //        ckB_TareaPagada.Checked = false;
        //    }
        //    else
        //    {
        //        Thread.Sleep(100);
        //        ckB_TareaPagada.Checked = true;
        //    }
        //}
        //private void ckB_TareaIniciada_MouseEnter(object sender, EventArgs e)
        //{
        //    if (ckB_TareaIniciada.Checked == true)
        //    {
        //        Thread.Sleep(100);
        //        ckB_TareaIniciada.Checked = false;
        //    }
        //    else
        //    {
        //        Thread.Sleep(100);
        //        ckB_TareaIniciada.Checked = true;
        //    }
        //}
        //private void checkBox5_MouseEnter(object sender, EventArgs e)
        //{
        //    if (ckB_TareaTerminada.Checked == true)
        //    {
        //        Thread.Sleep(100);
        //        ckB_TareaTerminada.Checked = false;
        //    }
        //    else
        //    {
        //        Thread.Sleep(100);
        //        ckB_TareaTerminada.Checked = true;
        //    }
        //}
        //private void checkBox2_MouseEnter(object sender, EventArgs e)
        //{
        //    if (ckB_EntregarPortal.Checked == true)
        //    {
        //        Thread.Sleep(100);
        //        ckB_EntregarPortal.Checked = false;
        //    }
        //    else
        //    {
        //        Thread.Sleep(100);
        //        ckB_EntregarPortal.Checked = true;
        //    }
        //}
        //private void textBox2_MouseHover(object sender, EventArgs e)
        //{
        //    tB_Descripccion.Focus();
        //}
        //private void dateTimePicker1_MouseHover(object sender, EventArgs e)
        //{
        //    dTP_Asignado.Select();
        //    SendKeys.Send("%{DOWN}");
        //}
        //private void dateTimePicker2_MouseHover(object sender, EventArgs e)
        //{
        //    dTP_Vencimiento.Focus();
        //    SendKeys.Send("%{DOWN}");
        //}
        //private void comboBox5_MouseHover(object sender, EventArgs e)
        //{
        //    cB_MetodoPagoTutor.DroppedDown = true;
        //}
        //private void comboBox1_MouseHover(object sender, EventArgs e)
        //{
        //    cB_MetodoPagoTarea.DroppedDown = true;
        //}
        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrar RegistrarEstudiante = new Registrar("Estudiante");
            RegistrarEstudiante.Show();
        }

        private void registrarTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrar RegistrarTutor = new Registrar("Tutor");
            RegistrarTutor.Show();
        }
        //private void btn_AgregarTarea_Click(object sender, EventArgs e)
        //{
        //    int indiceEstudianteComboBox = cB_Estudiante.SelectedIndex;
        //    int indiceTutorComboBox = cB_Tutor.SelectedIndex;
        //    tabControlTareas.SelectedTab = tabPageTareas;

        //    if (indiceEstudianteComboBox >= 0 && indiceEstudianteComboBox < listaEstudiantes.Count &&
        //        indiceTutorComboBox >= 0 && indiceTutorComboBox < listaTutores.Count)
        //    {
        //        Estudiante estudianteSeleccionado = listaEstudiantes[indiceEstudianteComboBox];
        //        Tutor tutorSeleccionado = listaTutores[indiceTutorComboBox];

        //    }
        //    else
        //    {
        //        //MensajeConsola("No se ha seleccionado un estudiante válido");
        //    }
        //}

        //private void cBEstudiante_MouseHover(object sender, EventArgs e)
        //{
        //    cB_Estudiante.DroppedDown = true;
        //}

        //private void cB_Tutor_MouseHover(object sender, EventArgs e)
        //{
        //    cB_Tutor.DroppedDown = true;
        //}

        //private void cB_Tema_MouseHover(object sender, EventArgs e)
        //{
        //    cB_Tema.DroppedDown = true;
        //}

        //private void ckB_PagadoTutor_MouseHover(object sender, EventArgs e)
        //{
        //    if (ckB_PagadoTutor.Checked == true)
        //    {
        //        ckB_PagadoTutor.Checked = false;
        //        dTP_TutorPagado.Enabled = false;
        //    }
        //    else
        //    {
        //        ckB_PagadoTutor.Checked = true;
        //        dTP_TutorPagado.Enabled = true;
        //    }
        //}

        //private void ckB_PagadaTarea_MouseEnter(object sender, EventArgs e)
        //{
        //    if (ckB_PagadaTarea.Checked == true)
        //    {
        //        ckB_PagadaTarea.Checked = false;
        //        dTP_TareaPagada.Enabled = false;
        //    }
        //    else
        //    {
        //        ckB_PagadaTarea.Checked = true;
        //        dTP_TareaPagada.Enabled = true;
        //    }
        //}

        //private void EditarTareaRapido(int idSeleccionado)
        //{
        //    bool tareaPagadaSeleccionada = pagosTareas.Any(p => p.Id_Tarea == idSeleccionado && p.Pagado.HasValue);
        //    ckB_TareaPagada.Checked = tareaPagadaSeleccionada;

        //    // Verificar si hay pagos para la tarea seleccionada en PagoTutor
        //    bool tutorPagadoSeleccionado = pagosTutores.Any(p => p.Id_Tarea == idSeleccionado && p.Pagado.HasValue);
        //    ckB_TutorPagado.Checked = tutorPagadoSeleccionado;

        //    // Buscar la tarea seleccionada en la lista de tareas pendientes
        //    Forms.Tarea tareaSeleccionada = tareasPendientes.FirstOrDefault(t => t.Id_Tarea == idSeleccionado);

        //    if (tareaSeleccionada != null)
        //    {
        //        // Verificar el estado de la tarea (iniciada, terminada, entregada)
        //        ckB_TareaIniciada.Checked = tareaSeleccionada.Iniciado.HasValue;
        //        ckB_TareaTerminada.Checked = tareaSeleccionada.Finalizado.HasValue;
        //        ckB_TareaEntregada.Checked = tareaSeleccionada.Entregado.HasValue;
        //    }
        //    else
        //    {
        //        // Si no se encontró la tarea en la lista de tareas pendientes, desactivar los CheckBox.
        //        ckB_TareaIniciada.Checked = false;
        //        ckB_TareaTerminada.Checked = false;
        //        ckB_TareaEntregada.Checked = false;
        //    }
        //}


        //private void dGV_TareasProgramadas_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        //{
        //    // Comprueba si el índice de la fila es par o impar
        //    if (e.RowIndex % 2 == 0)
        //    {
        //        // Fila par (negra)
        //        dGV_TareasProgramadas.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Black;
        //        dGV_TareasProgramadas.Rows[e.RowIndex].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
        //    }
        //    else
        //    {
        //        // Fila impar (gris)
        //        dGV_TareasProgramadas.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
        //        dGV_TareasProgramadas.Rows[e.RowIndex].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
        //    }
        //}

        //private void btn_Aplicar_Click(object sender, EventArgs e)
        //{
        //    if (idSeleccionado != -1)
        //    {
        //        // Obtener las fechas y el valor de horas
        //        DateTime? iniciado = null;
        //        DateTime? finalizado = null;
        //        DateTime? entregado = null;
        //        DateTime? tutorPagado = null;
        //        DateTime? tareaPagada = null;
        //        decimal horas = nUD_Horas.Value;
        //        if (ckB_TareaIniciada.Checked)
        //        {
        //            iniciado = DateTime.Now;
        //        }

        //        if (ckB_TareaTerminada.Checked)
        //        {
        //            finalizado = DateTime.Now;
        //        }

        //        if (ckB_TareaEntregada.Checked)
        //        {
        //            entregado = DateTime.Now;
        //        }
        //        if (ckB_TutorPagado.Checked)
        //        {
        //            tutorPagado = DateTime.Now;
        //        }
        //        if (ckB_TareaPagada.Checked)
        //        {
        //            tareaPagada = DateTime.Now;
        //        }
        //        // Llamar al método ActualizarTarea para actualizar los datos en la base de datos
        //        Forms.Tarea.ActualizarTarea(cadenaConexion, idSeleccionado, iniciado, finalizado, entregado, horas);
        //        PagoTarea.ActualizarPagoTarea(cadenaConexion, idPagoTarea(idSeleccionado), tareaPagada);
        //        PagoTutor.ActualizarPagoTutor(cadenaConexion, idPagoTutor(idSeleccionado), tutorPagado);

        //        // Actualizar la lista de tareas pendientes y recargar el DataGridView
        //        int idSeleccionadoo = idSeleccionado;
        //        CargarDatos();
        //        //// Buscar la fila correspondiente a idSeleccionado y seleccionarla en el DataGridView
        //        //foreach (DataGridViewRow row in dGV_TareasProgramadas.Rows)
        //        //{
        //        //    int idTarea = Convert.ToInt32(row.Cells["Id_Tarea"].Value);
        //        //    if (idTarea == idSeleccionadoo)
        //        //    {
        //        //        // Desmarcar cualquier otra fila seleccionada
        //        //        dGV_TareasProgramadas.ClearSelection();
        //        //        // Seleccionar la fila encontrada
        //        //        row.Selected = true;
        //        //        // Asegurarse de que la fila seleccionada sea visible en el DataGridView
        //        //        dGV_TareasProgramadas.FirstDisplayedScrollingRowIndex = row.Index;
        //        //        break;
        //        //    }
        //        //}

        //    }
        //    else
        //    {
        //        Terminal("Debe seleccionar una tarea primero.");
        //    }
        //}
        private int idPagoTarea(int idTarea)
        {
            // Buscar en la lista de pagosTareas el elemento que tenga el mismo Id_Tarea que el valor proporcionado
            PagoTarea pagoTarea = pagosTareas.FirstOrDefault(p => p.Id_Tarea == idTarea);
            // Si se encuentra el elemento, devolver el Id_PagoTarea; de lo contrario, devolver -1.
            return pagoTarea != null ? pagoTarea.Id_PagoTarea : -1;
        }

        private int idPagoTutor(int idTarea)
        {
            // Buscar en la lista de pagosTutores el elemento que tenga el mismo Id_Tarea que el valor proporcionado
            PagoTutor pagoTutor = pagosTutores.FirstOrDefault(p => p.Id_Tarea == idTarea);
            // Si se encuentra el elemento, devolver el Id_PagoTutor; de lo contrario, devolver -1.
            return pagoTutor != null ? pagoTutor.Id_PagoTutor : -1;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado != -1)
            {
                try
                {

                }
                catch (Exception ex)
                {
                    Terminal("Error al cancelar la tarea: " + ex.Message, "Error");
                }
            }
            else
            {
                Terminal("Debe seleccionar una tarea primero.", "Error");
            }
        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado != -1)
            {
                // Pregunta al usuario si está seguro de que quiere eliminar la tarea
                DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea eliminar esta tarea?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {

                        idSeleccionado = -1;
                    }
                    catch (Exception ex)
                    {
                        // Opción para mostrar el error en un mensaje de consola o en un cuadro de diálogo.
                        MessageBox.Show("Error al eliminar la tarea y sus pagos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Terminal("Error al eliminar la tarea y sus pagos: " + ex.Message, "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una tarea primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Terminal("Debe seleccionar una tarea primero.");
            }
        }
        private void CargarDatosTareaSeleccionada()
        {
            if (idSeleccionado != -1 && tabControlTareas.SelectedTab.Text == "Tareas")
            {
                // Buscar la tarea seleccionada en la lista de tareas pendientes
                Forms.Tarea tareaSeleccionada = tareasPendientes.FirstOrDefault(t => t.Id_Tarea == idSeleccionado);
                PagoTarea pagoTarea = pagosTareas.FirstOrDefault(pta => pta.Id_Tarea == idSeleccionado);
                PagoTutor pagoTutor = pagosTutores.FirstOrDefault(ptu => ptu.Id_Tarea == idSeleccionado);
                if (tareaSeleccionada != null)
                {
                    // Buscar los nombres de estudiante y tutor correspondientes a sus respectivos IDs
                    string nombreEstudiante = ObtenerNombreEstudiante((int)tareaSeleccionada.Id_Estudiante);
                    string nombreTutor = ObtenerNombreTutor((int)tareaSeleccionada.Id_Tutor);

                    // Cargar los datos en los controles
                    //cB_Estudiante.SelectedItem = nombreEstudiante;
                    //cB_Tutor.SelectedItem = nombreTutor;
                    //cB_Tema.Text = tareaSeleccionada.Tema;
                    //tB_Descripccion.Text = tareaSeleccionada.Descripcion;
                    //dTP_Asignado.Value = tareaSeleccionada.Asignado;
                    //dTP_Vencimiento.Value = tareaSeleccionada.Vencimiento;
                    //nUD_TutorPago.Value = pagoTutor.Precio;
                    //nUD_TareaPago.Value = pagoTarea.Precio;
                    //cB_MetodoPagoTutor.Text = pagoTutor.MetodoPago;
                    //cB_MetodoPagoTarea.Text = pagoTarea.MetodoPago;
                    //ckB_PagadoTutor.Checked = pagoTutor.Pagado != null;
                    //dTP_TutorPagado.Enabled = ckB_PagadoTutor.Checked;
                    //dTP_TutorPagado.Value = pagoTutor.Pagado ?? DateTime.Now;
                    //ckB_PagadaTarea.Checked = pagoTarea.Pagado != null;
                    //dTP_TareaPagada.Enabled = ckB_PagadaTarea.Checked;
                    //dTP_TareaPagada.Value = pagoTarea.Pagado ?? DateTime.Now;
                    //ckB_EntregarPortal.Checked = (bool)tareaSeleccionada.EntregarPortal;
                }
            }
            else if (tabControlTareas.SelectedTab.Text == "Scraper")
            {
                // Asegurarse de que hay una fila seleccionada
                if (dGV_TScraped.CurrentRow != null)
                {
                    int tareaSeleccionadaIndex = dGV_TScraped.CurrentRow.Index; // Aquí obtenemos el índice de la fila actual
                    Terminal("Fila seleccionada" + tareaSeleccionadaIndex);
                    // Asegurarse de que el índice es válido
                    //if (tareaSeleccionadaIndex >= 0 && tareaSeleccionadaIndex < TS.TareasScrapeadas.Count)
                    //{
                    //    // Cargar los datos en los controles
                    //    cB_Tema.Text = TS.TareasScrapeadas[tareaSeleccionadaIndex].Tema;
                    //    tB_Descripccion.Text = TS.TareasScrapeadas[tareaSeleccionadaIndex].Descripcion;
                    //    dTP_Vencimiento.Value = TS.TareasScrapeadas[tareaSeleccionadaIndex].Vencimiento;
                    //    cB_Estudiante.SelectedIndex = cB_ScraperEstudiante.SelectedIndex;
                    //}
                }

            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado != -1)
            {
                // Cargar los datos de la tarea seleccionada en los controles del formulario para edición
                CargarDatosTareaSeleccionada();
            }
            else
            {
                Terminal("Debe seleccionar una tarea primero.");
            }
        }

        private async void btn_ScrapearTareas_Click(object sender, EventArgs e)
        {
            //int indiceScraperEstudianteComboBox = cB_ScraperEstudiante.SelectedIndex;
            try
            {
                    Terminal("Scrapeado tareas ...");
                    TS = new TareasScraping(this);
                    await TS.Scraping("2931882022", "9EM@ñ()22a");
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Estudiante", typeof(string));
                    dataTable.Columns.Add("Tema", typeof(string));
                    dataTable.Columns.Add("Descripcion", typeof(string));
                    dataTable.Columns.Add("Vence", typeof(string));
                    dataTable.Columns.Add("nota", typeof(double));

                foreach (var tar in TS.TareasScrapeadas)
                    {
                        DataRow row = dataTable.NewRow();

                        row["Estudiante"] = "Jose";
                        row["Tema"] = tar.Tema;
                        row["Descripcion"] = tar.Descripcion;
                        row["Vence"] = tar.Vencimiento.ToString("M");
                        dataTable.Rows.Add(row);
                    }
                    dGV_TScraped.DataSource = dataTable;
                    dGV_TScraped.RowTemplate.Height = 35;
                    dGV_TScraped.Columns["Estudiante"].Width = 110;
                    dGV_TScraped.Columns["Tema"].Width = 100;
                    dGV_TScraped.Columns["Vence"].Width = 110;
                    dGV_TScraped.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    tabControlTareas.SelectedTab = tabPageScraper;
                    Terminal("Scrapeado tareas ...", "Scraping con éxito");
                
            }
            catch (Exception ex)
            {
                Terminal("Scrapeo ha fallado: " + ex.Message);
                return;
            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Comprueba si el índice de la fila es par o impar
            if (e.RowIndex % 2 == 0)
            {
                // Fila par (negra)
                dGV_TScraped.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Black;
                dGV_TScraped.Rows[e.RowIndex].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                // Fila impar (gris)
                dGV_TScraped.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
                dGV_TScraped.Rows[e.RowIndex].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            }
        }

        //private void cB_ScraperEstudiante_MouseHover(object sender, EventArgs e)
        //{
        //    cB_ScraperEstudiante.DroppedDown = true;
        //}

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControlTareas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlTareas.SelectedTab.Text == "Tareas")
            {
                //btn_Cargar.Enabled = false;
                //btn_Editar.Enabled = true;
                //btn_Borrar.Enabled = true;
                //btn_Cancelar.Enabled = true;
                //btn_Aplicar.Enabled = true;
            }
            else if (tabControlTareas.SelectedTab.Text == "Scraper")
            {
                //btn_Cargar.Enabled = true;
                //btn_Editar.Enabled = false;
                //btn_Borrar.Enabled = false;
                //btn_Cancelar.Enabled = false;
                //btn_Aplicar.Enabled = false;
            }
        }
        private void btn_Cargar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado != -1 && tabControlTareas.SelectedTab.Text == "Scraper")
            {
                // Cargar los datos de la tarea seleccionada en los controles del formulario para edición
                CargarDatosTareaSeleccionada();
            }
            else
            {
                Terminal("Debe seleccionar una tarea primero.");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}