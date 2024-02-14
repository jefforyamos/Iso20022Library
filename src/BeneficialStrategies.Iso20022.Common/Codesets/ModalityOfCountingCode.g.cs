﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ModalityOfCountingCode.  ISO2002 ID# _OLoUAK-uEemJ1NnLPsTFaw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Modality through which the votes that have been recorded and counted.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OLoUAK-uEemJ1NnLPsTFaw")]
[Description(@"Modality through which the votes that have been recorded and counted.")]
[Derivations(typeof(ModalityOfCounting1Code))]
public enum ModalityOfCountingCode
{
    /// <summary>
    /// Paper vote recorded and counted ahead of the meeting.
    /// Encoded/decoded by serializers as &quot;PVBM&quot;.
    /// </summary>
    [EnumMember(Value = "PVBM")]
    [IsoId("_fLXyoK-uEemJ1NnLPsTFaw")]
    [Description(@"Paper vote recorded and counted ahead of the meeting.")]
    PaperBefore,
    
    /// <summary>
    /// Electronic vote recorded and counted ahead of the meeting.
    /// Encoded/decoded by serializers as &quot;EVBM&quot;.
    /// </summary>
    [EnumMember(Value = "EVBM")]
    [IsoId("_uUoQwK-uEemJ1NnLPsTFaw")]
    [Description(@"Electronic vote recorded and counted ahead of the meeting.")]
    ElectronicBefore,
    
    /// <summary>
    /// Electronic vote recorded and counted at the meeting.
    /// Encoded/decoded by serializers as &quot;EVAM&quot;.
    /// </summary>
    [EnumMember(Value = "EVAM")]
    [IsoId("_04niMK-uEemJ1NnLPsTFaw")]
    [Description(@"Electronic vote recorded and counted at the meeting.")]
    ElectronicAtMeeting,
    
    /// <summary>
    /// Physical attendance with vote at the meeting.
    /// Encoded/decoded by serializers as &quot;PVAM&quot;.
    /// </summary>
    [EnumMember(Value = "PVAM")]
    [IsoId("__oPtoK-uEemJ1NnLPsTFaw")]
    [Description(@"Physical attendance with vote at the meeting.")]
    PhysicalAtMeeting,
    
}
