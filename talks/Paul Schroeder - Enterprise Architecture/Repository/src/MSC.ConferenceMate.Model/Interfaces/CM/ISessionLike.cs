// <auto-generated> - Template:ModelsBackedByDtoInterface, Version:1.1, Id:4d03f2c7-de27-4aae-a267-cad747c9606a
using System;
using System.Collections.Generic;

namespace MSC.ConferenceMate.Model.CM.Interface
{
	public partial interface ISessionLike
	{
		string CreatedBy { get; }
		System.DateTime CreatedUtcDate { get; }
		int DataVersion { get; }
		bool IsDeleted { get; }
		string ModifiedBy { get; }
		System.DateTime ModifiedUtcDate { get; }
		int SessionId { get; }
		int UserProfileId { get; }

		// Excluding 'Session' per configuration setting.
		IUserProfile UserProfile { get; }


	}
}
