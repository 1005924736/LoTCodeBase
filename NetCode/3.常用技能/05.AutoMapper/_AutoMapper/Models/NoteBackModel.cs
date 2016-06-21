namespace _AutoMapper
{
    /// <summary>
    /// 12���ֶΣ�add SeoTKD��
    /// </summary>
    public class NoteBackModel
    {
        /// <summary>
        /// ���
        /// </summary>
        public int NId { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string NTitle { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string NContent { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string NAuthor { get; set; }
        /// <summary>
        /// �������
        /// </summary>
        public int NHitCount { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public string NCreateTime { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public string NUpdateTime { get; set; }
        /// <summary>
        /// ����չͼ
        /// </summary>
        public string NDisplayPic { get; set; }
        /// <summary>
        /// �Ƿ����͵���ҳ
        /// </summary>
        public bool NPush { get; set; }
        /// <summary>
        /// SEO���ID
        /// </summary>
        public int NSeoId { get; set; }
        /// <summary>
        /// SEOInfo
        /// </summary>
        public SeoTKD SeoInfo { get; set; }
        /// <summary>
        /// ״̬
        /// </summary>
        public StatusEnum NDataStatus { get; set; }
        /// <summary>
        /// �����ֶ�
        /// </summary>
        public string Test { get; set; }
    }
}
