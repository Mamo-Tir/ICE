using System;
namespace ProjectTest.Models
{
	public class TodoModels
	{
	}

	public class TodoViewModel
	{
		public TodoModel Todo { get; set; }

		public bool isWindows { get; set; }
	}

	public class TodoModel
	{
		/// <summary>
		/// タイトル
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// 詳細
		/// </summary>
		public string Detail { get; set; }

		/// <summary>
		/// 備考
		/// </summary>
		public string Remakes { get; set; }

		/// <summary>
		/// 期限日
		/// </summary>
		public DateTime? LimitDate { get; set; }

		/// <summary>
		/// 優先度
		/// </summary>
		public Priority Priority { get; set; }

		/// <summary>
		/// 作成日
		/// </summary>
		public DateTime CreateDate { get; set; }

		/// <summary>
		/// 更新日
		/// </summary>
		public DateTime? UpdateTime { get; set; }

		/// <summary>
		/// 削除フラグ
		/// </summary>
		public bool DelFlag { get; set; }	
	}
}

