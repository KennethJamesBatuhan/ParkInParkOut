﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkInParkOut
{
    public partial class parkOutPanel : UserControl
    {
        FlowLayoutPanel[] parkoutSmallPanel;
        Label[] plateNumberLabels;
        Label[] parkinTimeLabels;
        Label[] vehicleTypeLabels;
        Label[] vehicleBrandLabels;
        Button[] parkOutButtons;
        List<String> parkInTime = new List<String>();
        List<String> plateNumber = new List<String>();
        List<String> vehicleType = new List<String>();
        List<String> vehicleBrand = new List<String>();
        public parkOutPanel()
        {
            InitializeComponent();
        }
        public void addParkInTime(String parkInTime)
        {
            this.parkInTime.Add(parkInTime);
        }
        public void addPlateNumber(String plateNumber)
        {
            this.plateNumber.Add(plateNumber);
        }
        public void addVehicleType(String vehicleType)
        {
            this.vehicleType.Add(vehicleType);
        }
        public void addVehicleBrand(String vehicleBrand)
        {
            this.vehicleBrand.Add(vehicleBrand);
        }
        public void parkedInVehicles()
        {
            flowLayoutPanel.Controls.Clear();
            parkoutSmallPanel = new FlowLayoutPanel[parkInTime.Count];
            plateNumberLabels = new Label[parkInTime.Count];
            parkinTimeLabels = new Label[parkInTime.Count];
            vehicleTypeLabels = new Label[parkInTime.Count];
            vehicleBrandLabels = new Label[parkInTime.Count];
            parkOutButtons = new Button[parkInTime.Count];

            for (int i = 0; i < parkInTime.Count; i++)
            {
                parkinTimeLabels[i] = new Label();
                plateNumberLabels[i] = new Label();
                vehicleTypeLabels[i] = new Label();
                vehicleBrandLabels[i] = new Label();
                parkOutButtons[i] = new Button();

                parkinTimeLabels[i].Text = parkInTime[i];
                plateNumberLabels[i].Text = plateNumber[i];
                vehicleTypeLabels[i].Text = vehicleType[i];
                vehicleBrandLabels[i].Text = vehicleBrand[i];
                parkOutButtons[i].Text = "Test";


                vehicleTypeLabels[i].Size = new Size(130, 29);
                vehicleBrandLabels[i].Size = new Size(140, 29);
                parkinTimeLabels[i].Size = new Size(140, 29);
                plateNumberLabels[i].Size = new Size(140, 29);
                parkOutButtons[i].Size = new Size(100, 29);

                parkinTimeLabels[i].TextAlign = ContentAlignment.MiddleCenter;
                plateNumberLabels[i].TextAlign = ContentAlignment.MiddleCenter;
                vehicleTypeLabels[i].TextAlign = ContentAlignment.MiddleCenter;
                vehicleBrandLabels[i].TextAlign = ContentAlignment.MiddleCenter;

                parkoutSmallPanel[i] = new FlowLayoutPanel();
                parkoutSmallPanel[i].FlowDirection = FlowDirection.LeftToRight;
                parkoutSmallPanel[i].Size = new Size(1000, 32);
                parkoutSmallPanel[i].BackColor = Color.AliceBlue;

                parkinTimeLabels[i].BackColor = Color.Red;
                plateNumberLabels[i].BackColor = Color.Blue;
                vehicleTypeLabels[i].BackColor = Color.Yellow;
                vehicleBrandLabels[i].BackColor = Color.Green;
                flowLayoutPanel.Controls.Add(parkoutSmallPanel[i]);


            }

            for (int i = 0; i < parkInTime.Count; i++)
            {
                parkoutSmallPanel[i].Controls.Add(parkinTimeLabels[i]);
                parkoutSmallPanel[i].Controls.Add(plateNumberLabels[i]);
                parkoutSmallPanel[i].Controls.Add(vehicleTypeLabels[i]);
                parkoutSmallPanel[i].Controls.Add(vehicleBrandLabels[i]);
                parkoutSmallPanel[i].Controls.Add(parkOutButtons[i]);
            }

        }
    }
}
