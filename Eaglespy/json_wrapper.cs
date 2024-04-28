using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

// Token: 0x0200001E RID: 30
public class json_wrapper
{
	// Token: 0x06000154 RID: 340 RVA: 0x00002166 File Offset: 0x00000366
	public static bool is_serializable(Type to_check)
	{
		return to_check.IsSerializable || to_check.IsDefined(typeof(DataContractAttribute), true);
	}

	// Token: 0x06000155 RID: 341 RVA: 0x0000C4B4 File Offset: 0x0000A6B4
	public json_wrapper(object obj_to_work_with)
	{
		this.current_object = obj_to_work_with;
		Type type = this.current_object.GetType();
		this.serializer = new DataContractJsonSerializer(type);
		if (!json_wrapper.is_serializable(type))
		{
			throw new Exception(string.Format("the object {0} isn't a serializable", this.current_object));
		}
	}

	// Token: 0x06000156 RID: 342 RVA: 0x0000C508 File Offset: 0x0000A708
	public object string_to_object(string json)
	{
		byte[] bytes = Encoding.Default.GetBytes(json);
		object result;
		using (MemoryStream memoryStream = new MemoryStream(bytes))
		{
			result = this.serializer.ReadObject(memoryStream);
		}
		return result;
	}

	// Token: 0x06000157 RID: 343 RVA: 0x00002184 File Offset: 0x00000384
	public T string_to_generic<T>(string json)
	{
		return (!!0)((object)this.string_to_object(json));
	}

	// Token: 0x04000095 RID: 149
	private DataContractJsonSerializer serializer;

	// Token: 0x04000096 RID: 150
	private object current_object;
}
