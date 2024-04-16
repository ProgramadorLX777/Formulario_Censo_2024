using System.Windows.Forms;

namespace Censo_Form
{
    public partial class Form1 : Form
    {
        private bool isDarkMode = false;

        public Form1()
        {
            InitializeComponent();

            // Sentencia para cambiar el título de ventana
            this.Text = "Formulario Censo 2024";

            button1 = new Button();
            button1.Text = "Cambiar color de fondo";
            button1.Click += new EventHandler(button1_Click); // Asignar el evento Click

            // Establecer la posición y el tamaño del botón
            button1.Location = new Point(10, 10); // Posición
            button1.Size = new Size(200, 50); // Tamaño

            // Crear nuevas pestañas con los títulos correctos
            TabPage tabPage1 = new TabPage("HOJA1");
            TabPage tabPage2 = new TabPage("HOJA2");
            TabPage tabPage3 = new TabPage("HOJA3");
            TabPage tabPage4 = new TabPage("HOJA4");

            // Añadir el botón a la primera pestaña
            tabPage1.Controls.Add(button1);

            StartPosition = FormStartPosition.Manual;
            Rectangle screen = Screen.FromPoint(Cursor.Position).WorkingArea;
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isDarkMode)
            {
                this.BackColor = Color.White;
                isDarkMode = false;
            }
            else
            {
                this.BackColor = Color.Black;
                isDarkMode = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lbl_encabezado.Text = ("Cuestionario Viviendas Particulares");
            lbl_titulo.Text = ("Censo de Población y Vivienda");
            lbl_id_vivienda.Text = ("Identificador de Vivienda (Uso Interno)");
            lbl_cuestionario.Text = ("Cuestionario");
            lbl_caracterizacion.Text = ("A. CARACTERIZACIÓN DE LA DIRECCIÓN");
            lbl_comuna.Text = ("Comuna");
            lbl_n_vivienda.Text = ("N° Vivienda");
            lbl_hogar.Text = ("N° Hogar");
            lbl_calle.Text = ("Nombre de Calle o Camino");
            lbl_domiciliario.Text = ("N° Domiciliario");
            lbl_letra.Text = ("N° o letra de Block, torre u otro");
            lbl_piso.Text = ("N° Piso");
            lbl_depto.Text = ("N° o letra Depto");
            lbl_distrito.Text = ("N° o letra Depto");
            lbl_entidad.Text = ("ENTIDAD");
            lbl_zona.Text = ("ZONA");
            lbl_manzana.Text = ("MANZANA");
            lbl_levantamiento.Text = ("ÁREA LEVANTAMIENTO");
            lbl_area.Text = ("ÁREA");
            rbtn_area_urbano.Text = ("Urbano");
            rbtn_area_rural.Text = ("Rural");
            lbl_nombre_censista.Text = ("Nombre Censista");
            lbl_rut.Text = ("Rut Censista");
            lbl_fecha_aplicacion.Text = ("Fecha Aplicacion Cuestionario");
            rbtn_area_rural.Text = ("Rural");
            rbtn_area_rural.Text = ("Rural");
            rbtn_area_rural.Text = ("Rural");

        }

        private void btnCambiarModo_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.White) // Modo día
            {
                this.BackColor = Color.Black; // Cambia a modo nocturno
                panel1.BackColor = Color.Black;
                panel_pag2.BackColor = Color.Black;
                // Agrega todos tus paneles aquí...
            }
            else
            {
                this.BackColor = Color.White; // Cambia a modo día
                panel1.BackColor = Color.White;
                panel_pag2.BackColor = Color.White;
                // Agrega todos tus paneles aquí...
            }
        }

        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void lbl_calle_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HOJA.SelectedIndex = 1; //cambia de pagina
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton47_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label58_Click(object sender, EventArgs e)
        {

        }

        private void label59_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton67_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton62_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label76_Click(object sender, EventArgs e)
        {

        }

        private void label82_Click(object sender, EventArgs e)
        {

        }

        private void label103_Click(object sender, EventArgs e)
        {

        }

        private void radioButton77_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton91_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox16_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton117_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label162_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void panel32_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label243_Click(object sender, EventArgs e)
        {

        }

        private void panel37_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel40_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel39_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton213_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label282_Click(object sender, EventArgs e)
        {

        }

        private void radioButton237_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label299_Click(object sender, EventArgs e)
        {

        }

        private void radioButton300_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label349_Click(object sender, EventArgs e)
        {

        }

        private void label141_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel69_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label400_Click(object sender, EventArgs e)
        {

        }

        private void label400_Click_1(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label87_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            // Visualizar Comuna
            lbl_visualizar_comuna.Text = txt_comuna.Text;

            // Visualizar Vivienda
            lbl_visualizar_n_vivienda.Text = txt_vivienda.Text;

            // Visualizar Hogar
            lbl_visualizar_n_hogar.Text = txt_hogar.Text;

            // Visualizar Nombre Calle
            lbl_visualizar_nom_calle.Text = txt_calle.Text;

            // Visualizar N° Domiciliario
            lbl_visualizar_n_domiciliario.Text = txt_domiciliario.Text;

            // Visualizar N° o Letra de Block
            lbl_visualizar_n_letra_block.Text = txt_letra.Text;

            // Visualizar N° Piso
            lbl_visualizar_n_piso.Text = txt_piso.Text;

            // Visualizar N° o Letra Depto
            lbl_visualizar_n_depto.Text = txt_depto.Text;

            // Visualizar Distrito
            lbl_visualizar_distrito.Text = txt_distrito.Text;

            // Visualizar Entidad
            lbl_visualizar_entidad2.Text = txt_entidad.Text;

            // Visualizar Zona
            lbl_visualizar_zona.Text = txt_zona.Text;

            // Visualizar Manzana
            lbl_visualizar_manzana.Text = txt_manzana.Text;

            // Visualizar Área Levantamiento
            lbl_visualizar_area_levantamiento.Text = txt_levantamiento.Text;

            // Visualizar Áreas
            if (rbtn_area_urbano.Checked)
            {
                lbl_visualizar_area.Text = "Urbano";
            }
            else if (rbtn_area_rural.Checked)
            {
                lbl_visualizar_area.Text = "Rural";
            }

            // Visualizar Nombre Censista
            lbl_visualizar_nom_censista.Text = txt_nombre_censista.Text;

            // Visualizar Rut Censista
            lbl_visualizar_rut_censista.Text = txt_rut.Text;

            // Visualizar Fecha Aplicación Censo
            lbl_visualizar_fecha_censo.Text = txt_fecha.Text;


            // 1. Visualizar Destino del sitio
            if (rbt_b_vivienda1_1.Checked)
            {
                lbl_visualizar_destino.Text = "Viv. Particular";
            }
            else if (rbt_b_vivienda1_2.Checked)
            {
                lbl_visualizar_destino.Text = "Viv. Colectiva";
            }
            else if (rbt_b_vivienda1_3.Checked)
            {
                lbl_visualizar_destino.Text = "Otro uso";
            }
            else if (rbt_b_vivienda1_4.Checked)
            {
                lbl_visualizar_destino.Text = "Sin edificación";
            }

            // 2. Tipo de vivienda particular
            if (rbt_b_viv_particular2_1.Checked)
            {
                lbl_visualizar_tipo_vivienda.Text = "Casa directo a calle";
            }
            else if (rbt_b_viv_particular2_2.Checked)
            {
                lbl_visualizar_tipo_vivienda.Text = "Casa en condominio cerrado";
            }
            else if (rbt_b_viv_particular2_3.Checked)
            {
                lbl_visualizar_tipo_vivienda.Text = "Departamento con ascensor";
            }
            else if (rbt_b_viv_particular2_4.Checked)
            {
                lbl_visualizar_tipo_vivienda.Text = "Departamento sin ascensor";
            }
            else if (rbt_b_viv_particular2_5.Checked)
            {
                lbl_visualizar_tipo_vivienda.Text = "Vivienda indígena";
            }
            else if (rbt_b_viv_particular2_6.Checked)
            {
                lbl_visualizar_tipo_vivienda.Text = "Pieza en casa antigua";
            }
            else if (rbt_b_viv_particular2_7.Checked)
            {
                lbl_visualizar_tipo_vivienda.Text = "Mediagua o derivados";
            }
            else if (rbt_b_viv_particular2_8.Checked)
            {
                lbl_visualizar_tipo_vivienda.Text = "Móvil o derivados";
            }
            else if (rbt_b_viv_particular2_9.Checked)
            {
                lbl_visualizar_tipo_vivienda.Text = "Otro tipo";
            }

            // 3. Estado de ocupación de la Vivienda
            if (rbt_b_ocupacion_viv3_1.Checked)
            {
                lbl_visualizar_estado_ocupacion.Text = "Informante acepta entrevista";
            }
            else if (rbt_b_ocupacion_viv3_2.Checked)
            {
                lbl_visualizar_estado_ocupacion.Text = "Moradores ausentes";
            }
            else if (rbt_b_ocupacion_viv3_3.Checked)
            {
                lbl_visualizar_estado_ocupacion.Text = "Informante rechaza entrevista";
            }
            else if (rbt_b_ocupacion_viv3_4.Checked)
            {
                lbl_visualizar_estado_ocupacion.Text = "Informante tiene impedimientos";
            }
            else if (rbt_b_ocupacion_viv3_5.Checked)
            {
                lbl_visualizar_estado_ocupacion.Text = "Informante no habla Español";
            }
            else if (rbt_b_ocupacion_viv3_6.Checked)
            {
                lbl_visualizar_estado_ocupacion.Text = "Otra razón";
            }
            else if (rbt_b_ocupacion_viv3_7.Checked)
            {
                lbl_visualizar_estado_ocupacion.Text = "En venta o arriendo";
            }
            else if (rbt_b_ocupacion_viv3_8.Checked)
            {
                lbl_visualizar_estado_ocupacion.Text = "Viv de Temporada";
            }
            else if (rbt_b_ocupacion_viv3_9.Checked)
            {
                lbl_visualizar_estado_ocupacion.Text = "Abandonada";
            }
            else if (rbt_b_ocupacion_viv3_10.Checked)
            {
                lbl_visualizar_estado_ocupacion.Text = "Otra razón";
            }

            // 4. Material Principal Construcción
            if (rbt_b_material_viv4_1.Checked)
            {
                lbl_visualizar_material.Text = "Hormigón armado";
            }
            else if (rbt_b_material_viv4_2.Checked)
            {
                lbl_visualizar_material.Text = "Albañilería";
            }
            else if (rbt_b_material_viv4_3.Checked)
            {
                lbl_visualizar_material.Text = "Tabique forrado";
            }
            else if (rbt_b_material_viv4_4.Checked)
            {
                lbl_visualizar_material.Text = "Tabique sin forro";
            }
            else if (rbt_b_material_viv4_5.Checked)
            {
                lbl_visualizar_material.Text = "Adobe, barro, pirca, entre otros";
            }
            else if (rbt_b_material_viv4_6.Checked)
            {
                lbl_visualizar_material.Text = "Materiales precarios";
            }
            else if (rbt_b_material_viv4_7.Checked)
            {
                lbl_visualizar_material.Text = "Tejas o tejuelas de arcilla";
            }
            else if (rbt_b_material_viv4_8.Checked)
            {
                lbl_visualizar_material.Text = "Losa hormigón";
            }
            else if (rbt_b_material_viv4_9.Checked)
            {
                lbl_visualizar_material.Text = "Planchas metálicas de zinc";
            }
            else if (rbt_b_material_viv4_10.Checked)
            {
                lbl_visualizar_material.Text = "Planchas de fibrocemento";
            }
            else if (rbt_b_material_viv4_11.Checked)
            {
                lbl_visualizar_material.Text = "Fonolita o plancha";
            }
            else if (rbt_b_material_viv4_12.Checked)
            {
                lbl_visualizar_material.Text = "Paja, coirón, totora";
            }
            else if (rbt_b_material_viv4_13.Checked)
            {
                lbl_visualizar_material.Text = "Materiales precarios o de desecho";
            }
            else if (rbt_b_material_viv4_14.Checked)
            {
                lbl_visualizar_material.Text = "Sin cubierto sólida de techo";
            }
            else if (rbt_b_material_viv4_15.Checked)
            {
                lbl_visualizar_material.Text = "Parquet, piso flotante, derivados";
            }
            else if (rbt_b_material_viv4_16.Checked)
            {
                lbl_visualizar_material.Text = "Radier sin revestimiento";
            }
            else if (rbt_b_material_viv4_17.Checked)
            {
                lbl_visualizar_material.Text = "Baldosa de cemento";
            }
            else if (rbt_b_material_viv4_18.Checked)
            {
                lbl_visualizar_material.Text = "Capa de cemento sobre tierra";
            }
            else if (rbt_b_material_viv4_19.Checked)
            {
                lbl_visualizar_material.Text = "Tierra";
            }

            // 5. Número de piezas como dormitorio:
            if (rbt_b_piezas_viv5_0.Checked)
            {
                lbl_visualizar_dormitorios.Text = "0";
            }
            else if (rbt_b_piezas_viv5_1.Checked)
            {
                lbl_visualizar_dormitorios.Text = "1";
            }
            else if (rbt_b_piezas_viv5_2.Checked)
            {
                lbl_visualizar_dormitorios.Text = "2";
            }
            else if (rbt_b_piezas_viv5_3.Checked)
            {
                lbl_visualizar_dormitorios.Text = "3";
            }
            else if (rbt_b_piezas_viv5_4.Checked)
            {
                lbl_visualizar_dormitorios.Text = "4";
            }
            else if (rbt_b_piezas_viv5_5.Checked)
            {
                lbl_visualizar_dormitorios.Text = "5";
            }
            else if (rbt_b_piezas_viv5_6.Checked)
            {
                lbl_visualizar_dormitorios.Text = "6";
            }

            // 6. Origen del agua:
            if (rbt_b_agua_viv6_1.Checked)
            {
                lbl_visualizar_origen_agua.Text = "Red pública";
            }
            else if (rbt_b_agua_viv6_2.Checked)
            {
                lbl_visualizar_origen_agua.Text = "Pozo o noria";
            }
            else if (rbt_b_agua_viv6_3.Checked)
            {
                lbl_visualizar_origen_agua.Text = "Camión alije";
            }
            else if (rbt_b_agua_viv6_4.Checked)
            {
                lbl_visualizar_origen_agua.Text = "Río, vertiente, canal, etc";
            }

            // 7. Sistema del agua:
            if (rbt_b_sistema_agua_viv7_1.Checked)
            {
                lbl_visualizar_sistema_agua.Text = "Con llave dentro de la vivienda";
            }
            else if (rbt_b_sistema_agua_viv7_2.Checked)
            {
                lbl_visualizar_sistema_agua.Text = "Con llave dentro del sitio, pero fuera";
            }
            else if (rbt_b_sistema_agua_viv7_3.Checked)
            {
                lbl_visualizar_sistema_agua.Text = "No tiene sistema, la acarrea";
            }

            // 8. El WC de la casa:
            if (rbt_b_wc_viv8_1.Checked)
            {
                lbl_visualizar_servicio_wc.Text = "Dentro de la vivienda";
            }
            else if (rbt_b_wc_viv8_2.Checked)
            {
                lbl_visualizar_servicio_wc.Text = "Fuera de la vivienda";
            }
            else if (rbt_b_wc_viv8_3.Checked)
            {
                lbl_visualizar_servicio_wc.Text = "Conectado a una fosa";
            }
            else if (rbt_b_wc_viv8_4.Checked)
            {
                lbl_visualizar_servicio_wc.Text = "Conectado a un pozo negro";
            }
            else if (rbt_b_wc_viv8_5.Checked)
            {
                lbl_visualizar_servicio_wc.Text = "En un cajón sobre acequia";
            }
            else if (rbt_b_wc_viv8_6.Checked)
            {
                lbl_visualizar_servicio_wc.Text = "En un cajón conectado a otro sistema";
            }
            else if (rbt_b_wc_viv8_7.Checked)
            {
                lbl_visualizar_servicio_wc.Text = "Baño Químico";
            }
            else if (rbt_b_wc_viv8_8.Checked)
            {
                lbl_visualizar_servicio_wc.Text = "Conectado a baño seco";
            }
            else if (rbt_b_wc_viv8_9.Checked)
            {
                lbl_visualizar_servicio_wc.Text = "No tiene servicio higiénico";
            }

            // 9. Electricidad de la casa:
            if (rbt_b_red_electrica_viv9_1.Checked)
            {
                lbl_visualizar_electricidad.Text = "Red pública";
            }
            else if (rbt_b_red_electrica_viv9_2.Checked)
            {
                lbl_visualizar_electricidad.Text = "Generador con diésel";
            }
            else if (rbt_b_red_electrica_viv9_3.Checked)
            {
                lbl_visualizar_electricidad.Text = "Placa solar";
            }
            else if (rbt_b_red_electrica_viv9_4.Checked)
            {
                lbl_visualizar_electricidad.Text = "Energía eólica";
            }
            else if (rbt_b_red_electrica_viv9_5.Checked)
            {
                lbl_visualizar_electricidad.Text = "Otro";
            }
            else if (rbt_b_red_electrica_viv9_6.Checked)
            {
                lbl_visualizar_electricidad.Text = "No tiene energía eléctrica";
            }

            // 10. Residentes de la casa:
            if (rbt_b_eliminar_basura_viv10_1.Checked)
            {
                lbl_visualizar_eliminacion_basura.Text = "La recogen los servicios de aseo";
            }
            else if (rbt_b_eliminar_basura_viv10_2.Checked)
            {
                lbl_visualizar_eliminacion_basura.Text = "La entierra y/o quema";
            }
            else if (rbt_b_eliminar_basura_viv10_3.Checked)
            {
                lbl_visualizar_eliminacion_basura.Text = "La deja en terreno eriazo";
            }
            else if (rbt_b_eliminar_basura_viv10_4.Checked)
            {
                lbl_visualizar_eliminacion_basura.Text = "La tira al río, laguna o mar";
            }
            else if (rbt_b_eliminar_basura_viv10_5.Checked)
            {
                lbl_visualizar_eliminacion_basura.Text = "Otro";
            }

            // 11. Cantidad residentes de la casa:
            if (rbt_visualizar_gastos_separadoss.Checked)
            {
                lbl_visualizar_num_personas.Text = "Una";
            }
            else
            {
                lbl_visualizar_num_personas.Text = txt_b_gastos_residentes_viv11_1_1.Text;
            }

            // 11.1. Cantidad residentes de la casa:
            if (rbt_b_gastos_residentes_viv11_1_1.Checked)
            {
                lbl_visualizar_gastos_alimentacion.Text = "Sí";
            }
            else if (rbt_b_gastos_residentes_viv11_1_2.Checked)
            {
                lbl_visualizar_gastos_alimentacion.Text = "No";
            }










        }

        private void label406_Click(object sender, EventArgs e)
        {

        }

        // Acciones de botones para avanzar
        private void button3_Click(object sender, EventArgs e)
        {
            HOJA.SelectedIndex = 2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HOJA.SelectedIndex = 3;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            HOJA.SelectedIndex = 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HOJA.SelectedIndex = 5;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            HOJA.SelectedIndex = 6;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HOJA.SelectedIndex = 7;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            HOJA.SelectedIndex = 8;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            HOJA.SelectedIndex = 9;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HOJA.SelectedIndex = 10;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            HOJA.SelectedIndex = 11;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            HOJA.SelectedIndex = 12;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            HOJA.SelectedIndex = 13;
        }

        private void btnCambiarModo_Click_1(object sender, EventArgs e)
        {
            if (this.BackColor == Color.LightSkyBlue) // Modo día
            {
                this.BackColor = Color.RoyalBlue; // Cambia a azul marino
                panel_pag1.BackColor = Color.RoyalBlue;
                panel_pag1.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag2.BackColor = Color.RoyalBlue;
                panel_pag2.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag3.BackColor = Color.RoyalBlue;
                panel_pag3.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag4_11.BackColor = Color.RoyalBlue;
                panel_pag4_11.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag4_11_1.BackColor = Color.RoyalBlue;
                panel_pag4_11_1.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag4_11_2.BackColor = Color.RoyalBlue;
                panel_pag4_11_2.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag4_8.BackColor = Color.RoyalBlue;
                panel_pag4_8.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag4_9.BackColor = Color.RoyalBlue;
                panel_pag4_9.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag5_12.BackColor = Color.RoyalBlue;
                panel_pag5_12.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag5_13.BackColor = Color.RoyalBlue;
                panel_pag5_13.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag5_14.BackColor = Color.RoyalBlue;
                panel_pag5_14.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag5_15.BackColor = Color.RoyalBlue;
                panel_pag5_15.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag6_titulo.BackColor = Color.RoyalBlue;
                panel_pag6_titulo.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag6_subtitulo.BackColor = Color.RoyalBlue;
                panel_pag6_subtitulo.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag7_titulo.BackColor = Color.RoyalBlue;
                panel_pag7_titulo.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag7_19.BackColor = Color.RoyalBlue;
                panel_pag7_19.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag7_20.BackColor = Color.RoyalBlue;
                panel_pag7_20.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag7_21.BackColor = Color.RoyalBlue;
                panel_pag7_21.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag7_22.BackColor = Color.RoyalBlue;
                panel_pag7_22.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag7_23.BackColor = Color.RoyalBlue;
                panel_pag7_23.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag7_24.BackColor = Color.RoyalBlue;
                panel_pag7_24.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag8_segunda.BackColor = Color.RoyalBlue;
                panel_pag8_segunda.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag8_25_26.BackColor = Color.RoyalBlue;
                panel_pag8_25_26.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag8_27.BackColor = Color.RoyalBlue;
                panel_pag8_27.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag8_28.BackColor = Color.RoyalBlue;
                panel_pag8_28.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag9_general.BackColor = Color.RoyalBlue;
                panel_pag9_general.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag9_29.BackColor = Color.RoyalBlue;
                panel_pag9_29.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag9_30.BackColor = Color.RoyalBlue;
                panel_pag9_30.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag9_31.BackColor = Color.RoyalBlue;
                panel_pag9_31.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag9_32.BackColor = Color.RoyalBlue;
                panel_pag9_32.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag9_33.BackColor = Color.RoyalBlue;
                panel_pag9_33.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag10_general.BackColor = Color.RoyalBlue;
                panel_pag10_general.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag10_34.BackColor = Color.RoyalBlue;
                panel_pag10_34.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag10_35.BackColor = Color.RoyalBlue;
                panel_pag10_35.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag10_36.BackColor = Color.RoyalBlue;
                panel_pag10_36.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag10_37.BackColor = Color.RoyalBlue;
                panel_pag10_37.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag10_38.BackColor = Color.RoyalBlue;
                panel_pag10_38.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag11_39.BackColor = Color.RoyalBlue;
                panel_pag11_39.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag11_40.BackColor = Color.RoyalBlue;
                panel_pag11_40.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag11_41.BackColor = Color.RoyalBlue;
                panel_pag11_41.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag11_42.BackColor = Color.RoyalBlue;
                panel_pag11_42.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag11_43.BackColor = Color.RoyalBlue;
                panel_pag11_43.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag11_44.BackColor = Color.RoyalBlue;
                panel_pag11_44.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag12_45.BackColor = Color.RoyalBlue;
                panel_pag12_45.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag12_46.BackColor = Color.RoyalBlue;
                panel_pag12_46.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag12_47.BackColor = Color.RoyalBlue;
                panel_pag12_47.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag12_48.BackColor = Color.RoyalBlue;
                panel_pag12_48.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel_pag12_49.BackColor = Color.RoyalBlue;
                panel_pag12_49.ForeColor = Color.White; // Cambia el color de la letra a blanco

                panel6.BackColor = Color.RoyalBlue;
                panel6.ForeColor = Color.White;

                panel7.BackColor = Color.RoyalBlue;
                panel7.ForeColor = Color.White;

                panel8.BackColor = Color.RoyalBlue;
                panel8.ForeColor = Color.White;

                panel10.BackColor = Color.RoyalBlue;
                panel10.ForeColor = Color.White;

                panel22.BackColor = Color.RoyalBlue;
                panel22.ForeColor = Color.White;

                panel23.BackColor = Color.RoyalBlue;
                panel23.ForeColor = Color.White;

                panel24.BackColor = Color.RoyalBlue;
                panel24.ForeColor = Color.White;

                panel25.BackColor = Color.RoyalBlue;
                panel25.ForeColor = Color.White;

                panel_pag13_50.BackColor = Color.RoyalBlue;
                panel_pag13_50.ForeColor = Color.White;


            }
            else
            {
                this.BackColor = Color.LightSkyBlue; // Cambia a modo día
                panel_pag1.BackColor = Color.LightSkyBlue;
                panel_pag1.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag2.BackColor = Color.LightSkyBlue;
                panel_pag2.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag3.BackColor = Color.LightSkyBlue;
                panel_pag3.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag4_11.BackColor = Color.LightSkyBlue;
                panel_pag4_11.ForeColor = Color.Black; // Cambia el color de la letra a blanco
                panel_pag4_11.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag4_11_1.BackColor = Color.LightSkyBlue;
                panel_pag4_11_1.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag4_11_2.BackColor = Color.LightSkyBlue;
                panel_pag4_11_2.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag4_8.BackColor = Color.LightSkyBlue;
                panel_pag4_8.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag4_9.BackColor = Color.LightSkyBlue;
                panel_pag4_9.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag5_12.BackColor = Color.LightSkyBlue;
                panel_pag5_12.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag5_13.BackColor = Color.LightSkyBlue;
                panel_pag5_13.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag5_14.BackColor = Color.LightSkyBlue;
                panel_pag5_14.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag5_15.BackColor = Color.LightSkyBlue;
                panel_pag5_15.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag6_titulo.BackColor = Color.LightSkyBlue;
                panel_pag6_titulo.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag6_subtitulo.BackColor = Color.LightSkyBlue;
                panel_pag6_subtitulo.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag7_titulo.BackColor = Color.LightSkyBlue;
                panel_pag7_titulo.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag7_19.BackColor = Color.LightSkyBlue;
                panel_pag7_19.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag7_20.BackColor = Color.LightSkyBlue;
                panel_pag7_20.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag7_21.BackColor = Color.LightSkyBlue;
                panel_pag7_21.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag7_22.BackColor = Color.LightSkyBlue;
                panel_pag7_22.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag7_23.BackColor = Color.LightSkyBlue;
                panel_pag7_23.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag7_24.BackColor = Color.LightSkyBlue;
                panel_pag7_24.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag8_segunda.BackColor = Color.LightSkyBlue;
                panel_pag8_segunda.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag8_25_26.BackColor = Color.LightSkyBlue;
                panel_pag8_25_26.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag8_27.BackColor = Color.LightSkyBlue;
                panel_pag8_27.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag8_28.BackColor = Color.LightSkyBlue;
                panel_pag8_28.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag9_general.BackColor = Color.LightSkyBlue;
                panel_pag9_general.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag9_29.BackColor = Color.LightSkyBlue;
                panel_pag9_29.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag9_30.BackColor = Color.LightSkyBlue;
                panel_pag9_30.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag9_31.BackColor = Color.LightSkyBlue;
                panel_pag9_31.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag9_32.BackColor = Color.LightSkyBlue;
                panel_pag9_32.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag9_33.BackColor = Color.LightSkyBlue;
                panel_pag9_33.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag10_general.BackColor = Color.LightSkyBlue;
                panel_pag10_general.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag10_34.BackColor = Color.LightSkyBlue;
                panel_pag10_34.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag10_35.BackColor = Color.LightSkyBlue;
                panel_pag10_35.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag10_36.BackColor = Color.LightSkyBlue;
                panel_pag10_36.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag10_37.BackColor = Color.LightSkyBlue;
                panel_pag10_37.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag10_38.BackColor = Color.LightSkyBlue;
                panel_pag10_38.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag11_39.BackColor = Color.LightSkyBlue;
                panel_pag11_39.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag11_40.BackColor = Color.LightSkyBlue;
                panel_pag11_40.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag11_41.BackColor = Color.LightSkyBlue;
                panel_pag11_41.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag11_42.BackColor = Color.LightSkyBlue;
                panel_pag11_42.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag11_43.BackColor = Color.LightSkyBlue;
                panel_pag11_43.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag11_44.BackColor = Color.LightSkyBlue;
                panel_pag11_44.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag12_45.BackColor = Color.LightSkyBlue;
                panel_pag12_45.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag12_46.BackColor = Color.LightSkyBlue;
                panel_pag12_46.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag12_47.BackColor = Color.LightSkyBlue;
                panel_pag12_47.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag12_48.BackColor = Color.LightSkyBlue;
                panel_pag12_48.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel_pag12_49.BackColor = Color.LightSkyBlue;
                panel_pag12_49.ForeColor = Color.Black; // Cambia el color de la letra a blanco

                panel6.BackColor = Color.LightSkyBlue;
                panel6.ForeColor = Color.Black;

                panel7.BackColor = Color.LightSkyBlue;
                panel7.ForeColor = Color.Black;

                panel8.BackColor = Color.LightSkyBlue;
                panel8.ForeColor = Color.Black;

                panel10.BackColor = Color.LightSkyBlue;
                panel10.ForeColor = Color.Black;

                panel22.BackColor = Color.LightSkyBlue;
                panel22.ForeColor = Color.Black;

                panel23.BackColor = Color.LightSkyBlue;
                panel23.ForeColor = Color.Black;

                panel24.BackColor = Color.LightSkyBlue;
                panel24.ForeColor = Color.Black;

                panel25.BackColor = Color.LightSkyBlue;
                panel25.ForeColor = Color.Black;

                panel_pag13_50.BackColor = Color.LightSkyBlue;
                panel_pag13_50.ForeColor = Color.Black;
            }
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void label403_Click(object sender, EventArgs e)
        {

        }

        private void panel70_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_visualizar_num_personas_Click(object sender, EventArgs e)
        {

        }

        private void panel65_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            HOJA.SelectedIndex = 3;
        }
    }
}