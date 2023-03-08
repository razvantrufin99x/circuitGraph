using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circuitGraph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        circuit c1 = new circuit(1);
       

        private void Form1_Load(object sender, EventArgs e)
        {
            c1.addDevice(new device(1));    
            c1.addDevice(new device(2));
            c1.devices[0].addInputPin(new pin(1, 0));
            c1.devices[0].addInputPin(new pin(2, 0));
            c1.devices[0].addOutputPin(new pin(3, 0));
            c1.devices[1].addInputPin(new pin(1, 0));
            c1.devices[1].addInputPin(new pin(2, 0));
            c1.devices[1].addOutputPin(new pin(3, 0));
            
            c1.addWire(new wire(1, c1.devices[0].pinOutput[0], c1.devices[1].pinInput[0]));

            //acum avem un fir care leaga doi pini la doua dispozitive diferite dela iesire unuia la intrarea celuilalt
            //putem crea o functie care sa prea valorile de la intrare dispozitivelor precum and(0,0) si care sa returneze un rezultat al operatiunii
            //acest rezultat este salvat la iesirea dispozitvului iar cum acesta este legat prin fir la dispozitivul secund
            //pe itrarea acestuia atunci pinul de la iesirea primului legat la pin de la intrarea celuilalt se vor transfera si valorile de la pin la pin prin fir
            //problema este daca am inregistrat acelasi pin sau sunt pin diferiti in fir si dispozitive
            //apoi putem sa cercetam ce dispoitive mai sunt legate unul de altul rezolvand circuitul
            //ce pastreaza functiile 

            //make an op c
            c1.devices[0].pinInput[0].value = 1;
            c1.devices[0].pinInput[1].value = 1;
            c1.devices[0].pinOutput[0].value = c1.c.add( c1.devices[0].pinInput[0], c1.devices[0].pinInput[1] );

            //transfer the value using wire fron device 1 o1 to device 2 pin i1
            c1.devices[1].pinInput[0].value = c1.devices[1].pinInput[0].value;
            c1.devices[1].pinInput[1].value = 1;
            c1.devices[1].pinOutput[0].value = c1.c.add(c1.devices[0].pinInput[0], c1.devices[0].pinInput[1]);

            Text += " : ";
            Text += c1.devices[1].pinOutput[0].value.ToString();

            //make an second op c
            c1.devices[0].pinInput[0].value = 0;
            c1.devices[0].pinInput[1].value = 1;
            c1.devices[0].pinOutput[0].value = c1.c.add(c1.devices[0].pinInput[0], c1.devices[0].pinInput[1]);

            //transfer the value using wire fron device 1 o1 to device 2 pin i1
            c1.devices[1].pinInput[0].value = c1.devices[1].pinInput[0].value;
            c1.devices[1].pinInput[1].value = 1;
            c1.devices[1].pinOutput[0].value = c1.c.add(c1.devices[0].pinInput[0], c1.devices[0].pinInput[1]);

            Text += " : ";
            Text += c1.devices[1].pinOutput[0].value.ToString();


            //pe viitor putem folosi deci un graf adica c1.wires adica lista de doi pini legati unul de altul
            //pentru ca sa simulam tot circuitul in loc sa scriem codul de mai sus
            //cautam numarul de dispozitive si gasim primul device si simulam
            //apoi cautam cate wire exista
            //selectam primul wire gasit si simulam circuitul 
            //..pana la final
            //..ruland codul in loop

        }
    }
}
