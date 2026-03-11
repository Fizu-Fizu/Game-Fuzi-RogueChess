public class Map
{
    // 地图
    public Node[][] map_1;
    public Node[][] map_2;
    public Node[][] map_3;
    public Node[][] map_4;
    // 当前位面
    public int realm = 1;
    // 下一位面
    public void add_realm()
    {
        if (this.realm < 4)
            this.realm += 1;
    }
    // 构造地图
    public Map(int seed)
    {
        map_1 = new Node[10][];
        map_2 = new Node[10][];
        map_3 = new Node[10][];
        map_4 = new Node[4][];
        for (int i = 0; i < 4; i++)
            map_4[i] = new Node[1];

        // 前三个是随机的，后一个固定，直接房间赋值
        NewMap(map_1, seed + 100000);
        NewMap(map_2, seed + 200000);
        NewMap(map_3, seed + 300000);
        map_4[0][0] = new Node(0, 0, 0);
        map_4[1][0] = new Node(1, 0, 2);
        map_4[1][0].next = new int[] { 0 };
        map_4[2][0] = new Node(2, 0, 6);
        map_4[2][0].next = new int[] { 0 };
        map_4[3][0] = new Node(3, 0, 5);
        map_4[3][0].next = new int[] { 0 };
    }
    // 创建地图
    public NewMap(Node[][] map, int seed)
    {
        for (int i = 0; i < map.Length; i++)
        {
            // 当前位面层数
            int temp_layer = i;
            // boss
            if (temp_layer == 0)
            {
                map[i] = new Node[1];
            }
            else
            {
                map[i] = new Node[6];
            }
            // 构造节点
            for (int j = 0; j < map[i].Length; j++)
            {
                int temp = j;
                NowSeed = seed + (temp_layer * 1000 + temp * 10);
                SysRandom rd = new SysRandom(NowSeed);

                // 从上往下生成，0 是 boss 间
                if (temp_layer == 0)
                {
                    map[i][j] = new Node(temp_layer, temp, 0, NowSeed);
                }
                else if (temp_layer == 1)
                {
                    map[i][j] = new Node(temp_layer, temp, 5, NowSeed);
                }
                else if (temp_layer == map.Length - 1)
                {
                    map[i][j] = new Node(temp_layer, temp, 1, NowSeed);
                }
                else
                {
                    map[i][j] = new Node(temp_layer, temp, rd.Next(1, 7), NowSeed);
                }
            }
        }
    }
}