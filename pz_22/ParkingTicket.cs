﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_22
{
    class ParkingTicket
    {
        private int ID;
        private float summ;
        private DateTime startTime;
        private DateTime endTime;
        private int carID;

        static int counter = 0;
        public static int Counter => counter;

        static float summAll = 0;

        private int Id
        {
            get { return ID; }
            set { ID = value; }
        }

        private DateTime StartTime
        {
            get { return startTime; }
            set { if (startTime < endTime) startTime = value; }
        }

        private float Summ
        {
            get { return summ; }
            set { for (int i = 0; i <= timePassed(); i++) summ += 50; }
        }

        int timePassed()
        {
            TimeSpan timePassed = endTime.Subtract(startTime);
            return timePassed.Hours;
        }

        public ParkingTicket(int iD, DateTime startTime, int carID)
        {
            ID = iD;
            this.summ = summCounter();
            this.startTime = startTime;
            this.carID = carID;
            summAll += summ;
            counter++;
        }

        public ParkingTicket(int id)
        {
            ID = id;
            startTime = DateTime.Now;
            endTime = startTime.AddHours(3);
            carID = 18;
            summ = summCounter();
            counter++;
            summAll += summ;

        }

        public void GetTicketInfo()
        {
            Console.WriteLine($"ID = {ID}\nСумма = {summ}\nНачало = {startTime}\nКонец = {endTime}\nID машины = {carID}");
        }

        public ParkingTicket()
        {
            this.ID += 1;
            this.Summ = 0;
            this.startTime = DateTime.Now;
            this.endTime = new DateTime(2023, 3, 18, 22, 25, 05);
            this.summ = summCounter();
            summAll += summ;
            counter++;
        }

        public void SetInfo()
        {
            Console.Write("Введите ваш ID - ");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите время окончания парковки (в формате чч:мм) - ");
            string hours = Console.ReadLine();
            GetTime(hours);
        }

        private float summCounter()
        {
            int hours = endTime.Hour - startTime.Hour;
            for (int i = 1; i < hours; i++)
            {
                summ += 50;
            }
            return summ;
        }

        private void GetTime(string hours)
        {
            int hour = Convert.ToInt32(hours.Substring(0, 2));
            int minute = Convert.ToInt32(hours.Substring(2, 2));
            endTime = new DateTime(2023, DateTime.Now.Month, DateTime.Now.Day, hour, minute, DateTime.Now.Second);
        }

        public void getInfo()
        {
            Console.WriteLine($"Айди - {ID} \nВремя начала - {startTime}\nВремя конца - {endTime} \nСумма - {summ}");
        }

        public void getticketsinfo()
        {
            Console.WriteLine($"Количество билетов - {counter}\nОбщая сумма - {summAll}");
        }

    }
}
