namespace Packt.CloudySkiesAir.Chapter2;

public class BaggageCalculator {
  //消除魔法數字
  private const decimal CarryOnFee = 30M;
  private const decimal FirstBagFee = 40M;
  private const decimal ExtraBagFee = 50M;

  //使用 Auto 屬性
  public decimal HolidayFeePercent { get; set; } = 0.1M;

  /// <summary>
  /// 所有隨身行李每件收費30元
  /// 乘客第一件託運行李收費40元
  /// 之後每一件託運行李收費50元
  /// 若搭乘日期適逢假期或國定假日，將適用10%的額外收費
  /// </summary>
  /// <param name="bags">行李數</param>
  /// <param name="carryOn">隨身行李數</param>
  /// <param name="passengers">乘客數</param>
  /// <param name="isHoleday">是否為假日</param>
  /// 
  /// <returns>行李費用的總價格</returns>
  public decimal CalculatePrice(int bags, int carryOn, int passengers, bool isHoleday) {

    decimal total = 0;

    //隨身行李費
    if (carryOn > 0) {
      //減少重複
      decimal fee = carryOn * CarryOnFee;
      Console.WriteLine($"Carry-on: {fee}");
      total += fee;
    }

    //託運行李費
    if (bags > 0) {
      decimal bagFee = CalculateCheckedBagFee(bags, passengers);
      Console.WriteLine($"Checked: {bagFee}");
      total += bagFee;
    }

    //假日加收費(11月~2月)
    if (isHoleday) {
      decimal holidayFee = total * HolidayFeePercent;
      Console.WriteLine("Holiday Fee: " + holidayFee);

      total += holidayFee;
    }

    return total;
  }

  private static decimal CalculateCheckedBagFee(int bags, int passengers) {
    if (bags <= passengers) {
      //減少重複
      decimal firstBagFee = bags * FirstBagFee;
      return firstBagFee;
    } else {
      //簡化複雜，行數變多，但可讀性提高
      decimal firstBagFee = passengers * FirstBagFee;
      decimal extraBagFee = (bags - passengers) * ExtraBagFee;
      decimal checkedFee = firstBagFee + extraBagFee;
      return checkedFee;
    }
  }
}
