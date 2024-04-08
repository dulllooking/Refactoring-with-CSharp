namespace Packt.CloudySkiesAir.Chapter2; 

public class Fee {
  public decimal Total { get; set; }

  //收取隨身行李費
  public void ChargeCarryOnBaggageFee(decimal fee) {
    Console.WriteLine($"Carry-on Fee: {fee}");
    Total += fee;
  }

  //收取託運行李費
  public void ChargeCheckedBaggageFee(decimal fee) {
    Console.WriteLine($"Checked Fee: {fee}");
    Total += fee;
  }
}
