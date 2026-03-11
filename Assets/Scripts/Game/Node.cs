public class Node
{

    // 层数
    public int layer;
    public int seed;  
    // 节点编号
    public int n;
    // 指向的节点
    public int[] next;
    //节点类型
    /*
    0 boss
    1 普通怪
    2 精英
    3 宝箱
    4 事件
    5 休整
    6 商店
     */
    public int type;
    // 构造函数
    public Node(int layer, int n, int type, int seed)
    {
        this.layer = layer;
        this.n = n;
        this.type = type;
        this.seed = seed;
    }
}