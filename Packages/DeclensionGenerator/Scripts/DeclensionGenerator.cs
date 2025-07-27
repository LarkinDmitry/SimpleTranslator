public class DeclensionGenerator
{
    /// <summary>
    /// ���������� ����� � ������, ��������� �� ��������� �����
    /// </summary>
    /// <param name="number">����� �� �������� ������� ��������� �����</param>
    /// <param name="nominativ">������������ ����� �����. �������� "����"</param>
    /// <param name="genetiv">����������� ����� �����. �������� "���"</param>
    /// <param name="plural">������������� ����� �����. �������� "����"</param>
    /// <returns></returns>
    public static string Generate(int number, string nominativ, string genetiv, string plural)
    {
        string[] titles = new string[] { nominativ, genetiv, plural };
        int[] cases = new[] { 2, 0, 1, 1, 1, 2 };
        return titles[number % 100 > 4 && number % 100 < 20 ? 2 : cases[(number % 10 < 5) ? number % 10 : 5]];
    }
}