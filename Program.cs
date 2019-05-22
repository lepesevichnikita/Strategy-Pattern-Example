using System;

/* В данном примере приводится несдандартная реализация паттерна "Стратегия"
 * "Классическая" Стратегия реализуется посредством создания общего интерфейса для алгоритмов, конкретные реализации которых передаются контексту.
 * Делегаты в этом примере выступают в роли заместителя интерфейса для группы алгоритмов в паттерне "Стратегия".
 *
 * Предметная область:  "Транспортная компания"
 * Проблема:            Перемещение из одного места в другое различными способами
 * Решение проблемы заключается в создании делегата для функций, которые будут выполнять перемещение из одной точки в другую
 */

namespace Strategy_Pattern_On_Delegate_Example
{
  public delegate void TransportationMethod(string startPlace, string endPlace);

  public class TransportCompany
  {
    private TransportationMethod _transportationMethod;

    public void setTransportationWay(TransportationMethod transportationMethod) {
      _transportationWay = transportationMethod;
    }

    public void moveFromTo(string startPlace, string endPlace) {
      _transportationMethod(startPlace, endPlace);
    }
  }
    class Program
    {
        static void Main(string[] args)
        {
          TransportCompany anotherOneTranportCompany = new TransportCompany();
          TransportationMethod byAir = new TransportationMethod((string startPlace, string endPlace) => Console.WriteLine("We are flying from {0} to {1}", startPlace, endPlace));
          TransportationMethod bySea = new TransportationMethod((string startPlace, string endPlace) => Console.WriteLine("We are sailing from {0} to {1}", startPlace, endPlace));
          TransportationMethod byTrain = new TransportationMethod((string startPlace, string endPlace) => Console.WriteLine("We are going by train from {0} to {1}", startPlace, endPlace));
          string startPlace = "New York";
          string endPlace = "Baltimore";
          anotherOneTranportCompany.setTransportationWay(byAir);
          anotherOneTranportCompany.moveFromTo(startPlace, endPlace);

          anotherOneTranportCompany.setTransportationWay(bySea);
          anotherOneTranportCompany.moveFromTo(startPlace, endPlace);

          anotherOneTranportCompany.setTransportationWay(byTrain);
          anotherOneTranportCompany.moveFromTo(startPlace, endPlace);
        }
    }
}
