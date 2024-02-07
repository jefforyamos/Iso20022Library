﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CancellationStatusReport.  ISO2002 ID# _n7iikkgrEeaD2L_hzZaE0w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.Status26Choice;

/// <summary>
/// Status report details of a bulk or multiple or switch order cancellation message.
/// </summary>
public partial record CancellationStatusReport : Status26Choice_
     , IIsoXmlSerilizable<CancellationStatusReport>
{
    #nullable enable
    
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    public IsoMax35Text? MasterReference { get; init; } 
    /// <summary>
    /// Cancellation status of the order cancellation.
    /// </summary>
    public required CancellationStatus22Choice_ CancellationStatus { get; init; } 
    /// <summary>
    /// Party that initiates the status of the order cancellation.
    /// </summary>
    public PartyIdentification113? StatusInitiator { get; init; } 
    
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
        if (MasterReference is IsoMax35Text MasterReferenceValue)
        {
            writer.WriteStartElement(null, "MstrRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MasterReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CxlSts", xmlNamespace );
        CancellationStatus.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (StatusInitiator is PartyIdentification113 StatusInitiatorValue)
        {
            writer.WriteStartElement(null, "StsInitr", xmlNamespace );
            StatusInitiatorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new CancellationStatusReport Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
