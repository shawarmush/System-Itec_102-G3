// PERSON 8 - Person8_FindAndSales.cs
// Laman: FindOrder, ShowSales, DeleteSalesHistory
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace RestaurantOrderSystem
{
    partial class Program
    {
        // CAR 1: trim, case-insensitive search
        static void FindOrder()
        {
            string id = ReadInput("Enter Order ID (e.g., ORD0001): ").ToUpper();

            if (id == "")
            {
                Console.WriteLine("Order ID cannot be blank. Please type an ID such as ORD0001.");
                return;
            }