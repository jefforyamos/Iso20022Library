﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MandateSuspension3.  ISO2002 ID# _d-QNUdcZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the mandate, which is being suspended.
/// </summary>
public partial record MandateSuspension3
     : IIsoXmlSerilizable<MandateSuspension3>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the initiating party, to unambiguously identify the suspension request.
    /// </summary>
    public required IsoMax35Text SuspensionRequestIdentification { get; init; } 
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; } 
    /// <summary>
    /// Provides detailed information on the suspension reason.
    /// </summary>
    public required MandateSuspensionReason2 SuspensionReason { get; init; } 
    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    public required OriginalMandate9Choice_ OriginalMandate { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init; } 
    
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
        writer.WriteStartElement(null, "SspnsnReqId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(SuspensionRequestIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (OriginalMessageInformation is OriginalMessageInformation1 OriginalMessageInformationValue)
        {
            writer.WriteStartElement(null, "OrgnlMsgInf", xmlNamespace );
            OriginalMessageInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SspnsnRsn", xmlNamespace );
        SuspensionReason.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "OrgnlMndt", xmlNamespace );
        OriginalMandate.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static MandateSuspension3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
