﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionCancellationProcessingStatus1.  ISO2002 ID# _RlD3Vdp-Ed-ak6NoX_4Aeg_-1533879577.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provide processing status information of an election advice.
/// </summary>
public partial record CorporateActionCancellationProcessingStatus1
     : IIsoXmlSerilizable<CorporateActionCancellationProcessingStatus1>
{
    #nullable enable
    
    /// <summary>
    /// The processing status.
    /// </summary>
    public required ProcessedStatus5FormatChoice_ Status { get; init; } 
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
        writer.WriteStartElement(null, "Sts", xmlNamespace );
        Status.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AdditionalInformation is IsoMax350Text AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(AdditionalInformationValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
    }
    public static CorporateActionCancellationProcessingStatus1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
