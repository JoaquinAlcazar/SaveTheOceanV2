using SaveTheOceanLib;
using SaveTheOceanV2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveTheOceanV2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            //La verdad es que no me suele funcionar hacer esto con los eventos load, así que me ahorro el paso
            //lo siento, quiero tener algo que funcione

            //Crear un nuevo animal
            animal animal = createAnimal();

            //Crear un nuevo rescate
            rescue rescue = createRescue(animal);

            //Mostrarlos en los dataGridView
            ShowAnimalInDataGridView(animal);
            ShowRescueInDataGridView(rescue);

            //Guardar ambos para pasarselo al botón de tratar y de trasladar
            AnimalRescueData data = new AnimalRescueData
            {
                Animal = animal,
                Rescue = rescue
            };
            button1.Tag = data;
            button2.Tag = data;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ShowAnimalInDataGridView(animal animalToShow)
        {
            // Crear una nueva instancia de BindingSource
            BindingSource bindingSource = new BindingSource();

            // Asignar el animal a la lista del BindingSource
            bindingSource.Add(animalToShow);

            // Asignar el BindingSource al dataGridView como origen de datos
            dataGridViewAnimal.DataSource = bindingSource;
        }

        private animal createAnimal()
        {
            animal animal = new animal();
            animal.generateSfamily();
            animal.generateFamily();
            animal.generateName();
            animal.setAD();
            return animal;
        }

        private rescue createRescue(animal animal)
        {
            Random random = new Random();
            int rescueNum = random.Next(0, 1000);
            rescue rescue = new rescue(rescueNum, animal.Sfamily, animal.AffectDegree);
            rescue.setLocation();
            return rescue;
        }

        private void ShowRescueInDataGridView(rescue rescueToShow)
        {
            // Crear una nueva instancia de BindingSource
            BindingSource bindingSource = new BindingSource();

            // Asignar el animal a la lista del BindingSource
            bindingSource.Add(rescueToShow);

            // Asignar el BindingSource al dataGridView como origen de datos
            dataGridViewRescue.DataSource = bindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnimalRescueData data = (AnimalRescueData)button1.Tag;
            data.Animal.treat(data.Rescue.localization);
            if (data.Animal.AffectDegree <= 30)
            {
                MessageBox.Show("El animal ha sido tratado con éxito y has ganado 50 puntos de experiencia");
                player player = player.LoadFromXml(@"./../../../Files/player.xml");
                player.experience += 50;
                player.SaveToXml();
            }
            else
            {
                MessageBox.Show("El animal no ha sido tratado con éxito, -20EXP");
                player player = player.LoadFromXml(@"./../../../Files/player.xml");
                player.experience -= 20;
                player.SaveToXml();
            }
            try
            {
                persistRescue(data);
            }catch (Exception ex)
            {
                
            }
            

            //Crear un nuevo animal
            animal animal = createAnimal();

            //Crear un nuevo rescate
            rescue rescue = createRescue(animal);

            //Mostrarlos en los dataGridView
            ShowAnimalInDataGridView(animal);
            ShowRescueInDataGridView(rescue);

            //Guardar ambos para pasarselo al botón de tratar y de trasladar
            AnimalRescueData newData = new AnimalRescueData
            {
                Animal = animal,
                Rescue = rescue
            };
            button1.Tag = newData;
            button2.Tag = newData;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnimalRescueData data = (AnimalRescueData)button1.Tag;
            data.Animal.treat("CRAM");
            if (data.Animal.AffectDegree <= 30)
            {
                MessageBox.Show("El animal ha sido tratado con éxito y has ganado 50 puntos de experiencia");
                player player = player.LoadFromXml(@"./../../../Files/player.xml");
                player.experience += 50;
                player.SaveToXml();
            }
            else
            {
                MessageBox.Show("El animal no ha sido tratado con éxito, -20EXP");
                player player = player.LoadFromXml(@"./../../../Files/player.xml");
                player.experience -= 20;
                player.SaveToXml();
            }
            try
            {
                persistRescue(data);
            }
            catch (Exception ex)
            {

            }
            //Crear un nuevo animal
            animal animal = createAnimal();

            //Crear un nuevo rescate
            rescue rescue = createRescue(animal);

            //Mostrarlos en los dataGridView
            ShowAnimalInDataGridView(animal);
            ShowRescueInDataGridView(rescue);

            //Guardar ambos para pasarselo al botón de tratar y de trasladar
            AnimalRescueData newData = new AnimalRescueData
            {
                Animal = animal,
                Rescue = rescue
            };
            button1.Tag = newData;
            button2.Tag = newData;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            player player = player.LoadFromXml(@"./../../../Files/player.xml");
            MessageBox.Show("Has terminado con " + player.experience + " puntos de experiencia");
            this.Close();
        }

        private void persistRescue(AnimalRescueData data)
        {
            RescueDAO rescueDAO = new RescueDAO("Host=localhost;Port=5432;Username=JoaquínAlcazar;Password=indescifrable1;Database=rescates;\r\n");
            rescueDAO.InsertRescue( data.Rescue , data.Animal.Sfamily, data.Rescue.localization, data.Rescue.affectDegree);
        }
    }
}
