namespace _AutoMapper
{
    /// <summary>
    /// 7���ֶ�
    /// </summary>
    public partial class NoteViewModel
    {
        /// <summary>
        /// ���
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// �������
        /// </summary>
        public int HitCount { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public string CreateTime { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public string UpdateTime { get; set; }
        /// <summary>
        /// ״̬
        /// </summary>
        public StatusEnum DataStatus { get; set; }
        /// <summary>
        /// �����ֶ�
        /// </summary>
        public string Test { get; set; }
    }
}
