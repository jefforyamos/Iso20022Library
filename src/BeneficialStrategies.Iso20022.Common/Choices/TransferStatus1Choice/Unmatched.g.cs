﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Unmatched.  ISO2002 ID# _o1CqqhwkEeOIveEnnb_1-A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.TransferStatus1Choice;

/// <summary>
/// Status of the transfer is unmatched.
/// </summary>
public partial record Unmatched : TransferStatus1Choice_
     , IIsoXmlSerilizable<Unmatched>
{
    #nullable enable
    
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    public required NoReasonCode NoSpecifiedReason { get; init; } 
    /// <summary>
    /// Reason for the unmatched status.
    /// </summary>
    public required TransferUnmatchedReason2Code Reason { get; init; } 
    /// <summary>
    /// Reason for the unmatched status.
    /// </summary>
    public required IsoExtended350Code ExtendedReason { get; init; } 
    /// <summary>
    /// Proprietary identification of the reason for the unmatched status.
    /// </summary>
    public required GenericIdentification1 DataSourceScheme { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "NoSpcfdRsn", xmlNamespace );
        writer.WriteValue(NoSpecifiedReason.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Rsn", xmlNamespace );
        writer.WriteValue(Reason.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "XtndedRsn", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoExtended350Code(ExtendedReason)); // data type Extended350Code System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "DataSrcSchme", xmlNamespace );
        DataSourceScheme.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static new Unmatched Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
