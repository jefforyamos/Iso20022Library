﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionStandingInstructionCancellationRejectionStatus1.  ISO2002 ID# _Rk6tZNp-Ed-ak6NoX_4Aeg_1198444441.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides reason of the rejection of a standing instruction cancellation request.
/// </summary>
public partial record CorporateActionStandingInstructionCancellationRejectionStatus1
     : IIsoXmlSerilizable<CorporateActionStandingInstructionCancellationRejectionStatus1>
{
    #nullable enable
    
    /// <summary>
    /// The rejection reason.
    /// </summary>
    public RejectionReason10FormatChoice_? Reason { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _Rk6tZdp-Ed-ak6NoX_4Aeg_1289872620
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        // Not sure how to serialize Reason, multiplicity Unknown
        if (AdditionalInformation is IsoMax350Text AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(AdditionalInformationValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
    }
    public static CorporateActionStandingInstructionCancellationRejectionStatus1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
