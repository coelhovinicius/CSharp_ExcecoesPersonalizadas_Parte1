/* EXCECOES PERSONALIZADAS
    
    Exemplo: Fazer um programa para ler os dados de uma reserva de hotel (número do quarto, data de entrada e data de saída)
    e mostrar os dados da reserva, inclusive sua duração em dias. Em seguida, ler novas datas de entrada e saída, atualizar
    a reserva, e mostrar novamente a reserva com os dados atualizados. O programa não deve aceitar dados inválidos para a
    reserva, conforme as seguintes regras:
    - Alterações de reserva só podem ocorrer para datas futuras
    - A data de saída deve ser maior que a data de entrada
 */

/* >>> PROGRAMA PRINCIPAL <<< */
using System;
using Aula143_ExcecoesPersonalizadas.Entities;

namespace Aula143_ExcecoesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room Number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Booking error: Check-in date must be earlier than check-out date");
            }
            else
            {
                Booking booking = new Booking(roomNumber, checkIn, checkOut);
                Console.WriteLine("Booking: " + booking);

                Console.WriteLine();
                Console.WriteLine("Enter new dates for rebooking: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;
                if (checkIn < now || checkOut < now)
                {
                    Console.WriteLine("Rebooking error: Dates must be later than today");
                }
                else if (checkOut <= checkIn)
                {
                    Console.WriteLine("Booking error: Check-out date must be later than check-in date");
                }
                else
                {
                    booking.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Booking: " + booking);
                }
            }
        }
    }
}


