namespace ContosoPizza.Models
{
    /// <summary>
    /// ����� ������ ��� ������� Pizza
    /// </summary>
    public class Pizza
    {
        /// <summary>
        /// Id �������
        /// </summary>
        public int Id {get; set; }
        /// <summary>
        /// ������������
        /// </summary>
        public string Name {get; set;}
        /// <summary>
        /// ���� �� ���������� ������� 
        /// </summary>
        public bool IsGlutenFree {get; set;}
    }
}