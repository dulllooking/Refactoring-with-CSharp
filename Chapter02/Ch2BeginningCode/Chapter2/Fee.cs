namespace Packt.CloudySkiesAir.Chapter2; 

public class Fee {
  public decimal Total { get; set; }

  //收取託運行李費
  public void ChargeFee(decimal fee, string chargeName) {
    Console.WriteLine($"{chargeName}: {fee}");
    Total += fee;
  }
}
