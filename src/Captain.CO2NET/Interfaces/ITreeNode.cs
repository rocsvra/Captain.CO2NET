namespace Captain.CO2NET.Interfaces
{
    /// <summary>
    /// 树节点
    /// </summary>
    public interface ITreeNode
    {
        /// <summary>
        /// 节点ID
        /// </summary>
        string Id { get; set; }
        /// <summary>
        /// 父节点ID
        /// </summary>
        string ParentId { get; set; }
    }
}
