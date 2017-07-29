/*
 * Author:  Rick
 * Create:  7/29/2017 10:26:14 AM
 * Email:   rickjiangshu@gmail.com
 * Follow:  https://github.com/RickJiangShu
 */

/// <summary>
/// 操作位工具
/// </summary>
public class BitUtils
{
    /// <summary>
    /// 设置value的index位设置为1
    /// </summary>
    /// <param name="value"></param>
    /// <param name="index"></param>
    public static int Set(int value, int index)
    {
        return value | 1 << index;
    }

    /// <summary>
    /// 将value的idnex位设置为0
    /// </summary>
    /// <param name="value"></param>
    /// <param name="index"></param>
    /// <returns></returns>
    public static int Clear(int value, int index)
    {
        return value & ~(1 << index);
    }

    /// <summary>
    /// 检查value的index位是否为1
    /// </summary>
    /// <param name="value"></param>
    /// <param name="index"></param>
    /// <returns></returns>
    public static bool Get(int value, int index)
    {
        return (value >> index & 1) == 1;
    }
}
