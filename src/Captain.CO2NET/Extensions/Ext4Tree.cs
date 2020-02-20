using Captain.CO2NET.Interfaces;
using System.Collections.Generic;

namespace Captain.CO2NET.Extensions
{
    /// <summary>
    /// 树
    /// </summary>
    public static class Ext4Tree
    {
        /// <summary>
        /// 当前节点是否目标节点的下级节点
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="selfNode">当前节点</param>
        /// <param name="targetNode">目标节点</param>
        /// <param name="treeNodes">树节点列表</param>
        /// <returns></returns>
        public static bool IsSubNode<T>(this T selfNode, T targetNode, List<T> treeNodes) where T : ITreeNode
        {
            if (treeNodes.Exists(o => o.Id == selfNode.ParentId))
            {
                return selfNode.ParentId == targetNode.Id
                    ? true
                    : treeNodes.Find(o => o.Id == selfNode.ParentId).IsSubNode(targetNode, treeNodes);
            }
            return false;
        }
    }
}
