using System.IO;
using Core;
using Core.Serializer;


/// <summary>
/// 文件自动生成无需又该！如果出现编译错误，删除文件后会自动生成
/// </summary>
namespace Model
{
public partial class DBQueryRequest
{
	public override void Serialize(BinaryWriter rWriter)
	{
		base.Serialize(rWriter);
		rWriter.Serialize(this.CollectionName);
		rWriter.Serialize(this.Id);
		rWriter.Serialize(this.NeedCache);
	}
	public override void Deserialize(BinaryReader rReader)
	{
		base.Deserialize(rReader);
		this.CollectionName = rReader.Deserialize(this.CollectionName);
		this.Id = rReader.Deserialize(this.Id);
		this.NeedCache = rReader.Deserialize(this.NeedCache);
	}
}
}
