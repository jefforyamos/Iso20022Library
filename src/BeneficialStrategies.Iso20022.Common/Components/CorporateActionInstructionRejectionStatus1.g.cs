﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionInstructionRejectionStatus1.  ISO2002 ID# _Rkw8Ydp-Ed-ak6NoX_4Aeg_-175735359.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides reason of the rejection of an election advice.
/// </summary>
public partial record CorporateActionInstructionRejectionStatus1
     : IIsoXmlSerilizable<CorporateActionInstructionRejectionStatus1>
{
    #nullable enable
    
    /// <summary>
    /// The rejection reason.
    /// </summary>
    public RejectionReason18FormatChoice_? Reason { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _Rkw8Ytp-Ed-ak6NoX_4Aeg_-147105631
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
    public static CorporateActionInstructionRejectionStatus1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
