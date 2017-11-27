﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DTO;
using Interfaces;
using ObserverPattern;

namespace PresentationLogic
{
    public partial class Måling : Form, IPresentationObserver
    {
        private IBusinessLogic _iBusinessLogic;
        private Monitoreringsindstillinger _monitoring;
        private PresentationDataContainer _container;
        public Måling(IBusinessLogic iBusinessLogic, Monitoreringsindstillinger monitoring, PresentationDataContainer container)
        {
            InitializeComponent();
            _iBusinessLogic = iBusinessLogic;
            _monitoring = monitoring;
            _container = container;
        }

        public new void Update()
        {
            var data = _container.GetSlidingWindow();

            UpdateChart(data);
            UpdateBPValues(_container);
        }

        private void UpdateChart(List<double> data) 
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateChart(data)));
            }
            else
            {
                chart1.Series[0].Points.Clear();
                for (int i = 0; i < data.Count; i++)
                {
                    chart1.Series[0].Points.Add(data[i], i);
                }
                //var bleh = data.Count - 1;
                //for (int i = bleh; i < 4000; i++)
                //{
                //    chart1.Series[0].Points.AddXY(0, 0);
                //}
            }
        }

        private void UpdateBPValues(PresentationDataContainer container)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateBPValues(container)));
            }
            else
            {
                label_SysDia.Text = Convert.ToString(container.SystolicPressure) + " / " +
                                    Convert.ToString(container.DiastolicPressure);
                label_MiddelBT.Text = Convert.ToString(container.AverageBloodPressure);
                label_Puls.Text = Convert.ToString(container.Pulse);
            }
        }

        public void AttachToSubject(MeasurementSubjectBL subject)
        {
            subject.Attach(this);
        }

        public void DetachFromSubject(MeasurementSubjectBL subject)
        {
            subject.Detach(this);
        }

        private void btn_StartMåling_Click(object sender, EventArgs e)
        {
            _container.Attach(this);
            var t1 = new Thread(_iBusinessLogic.StartShowData);
            t1.Start();
        }
    }
}
