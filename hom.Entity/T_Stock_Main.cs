/**  版本信息模板在安装目录下，可自行修改。
* T_Stock_Main.cs
*
* 功 能： N/A
* 类 名： T_Stock_Main
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/4/27 9:33:54   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace hom.Entity
{
	/// <summary>
	/// T_Stock_Main:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_Stock_Main
	{
		public T_Stock_Main()
		{}
		#region Model
		private string _code;
		private string _name;
		private decimal _price;
		private string _market;
		private string _plate;
		private int? _status;
		private decimal? _maxprice;
		private decimal? _minprice;
		private DateTime? _historyrecorddate;
		private decimal? _locationpercent;
		private DateTime? _createtime;
		private DateTime? _updatetime;
		/// <summary>
		/// 代码
		/// </summary>
		public string Code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 名称
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 当前股价
		/// </summary>
		public decimal Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 沪A 深A
		/// </summary>
		public string Market
		{
			set{ _market=value;}
			get{return _market;}
		}
		/// <summary>
		/// 板块，创业板
		/// </summary>
		public string Plate
		{
			set{ _plate=value;}
			get{return _plate;}
		}
		/// <summary>
		/// 停牌，正常，退市
		/// </summary>
		public int? Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 历史最高价
		/// </summary>
		public decimal? MaxPrice
		{
			set{ _maxprice=value;}
			get{return _maxprice;}
		}
		/// <summary>
		/// 历史最低价
		/// </summary>
		public decimal? MinPrice
		{
			set{ _minprice=value;}
			get{return _minprice;}
		}
		/// <summary>
		/// 记录历史价格的日期
		/// </summary>
		public DateTime? HistoryRecordDate
		{
			set{ _historyrecorddate=value;}
			get{return _historyrecorddate;}
		}
		/// <summary>
		/// 当前所属比例 (当前股价-历史最低价）/ (历史最高价-历史最低价)
		/// </summary>
		public decimal? LocationPercent
		{
			set{ _locationpercent=value;}
			get{return _locationpercent;}
		}
		/// <summary>
		/// 创建日期
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 最后修改日期
		/// </summary>
		public DateTime? UpdateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		#endregion Model

	}
}

