﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CancellationStatusAndReason2.  ISO2002 ID# _SxzXTNp-Ed-ak6NoX_4Aeg_195934515.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of a transfer cancellation instruction and the reason for the status.
/// </summary>
public partial record CancellationStatusAndReason2
     : IIsoXmlSerilizable<CancellationStatusAndReason2>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    public IsoMax35Text? MasterReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of a transfer, as assigned by the instructing party.
    /// </summary>
    public required IsoMax35Text TransferReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous investor's identification of a transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    public IsoMax35Text? ClientReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    public IsoMax35Text? CancellationReference { get; init; } 
    /// <summary>
    /// Status of the transfer cancellation is accepted or sent to next party.
    /// </summary>
    public required TransferCancellationStatus2 Status { get; init; } 
    /// <summary>
    /// Status of the transfer cancellation is rejected.
    /// </summary>
    public required TransferCancellationRejectedStatus1 Rejected { get; init; } 
    /// <summary>
    /// Status of the transfer cancellation is complete. The cancellation instruction has been accepted and processed, the cancellation is complete.
    /// </summary>
    public required TransferCancellationCompleteStatusAndReason1 Complete { get; init; } 
    /// <summary>
    /// Status of the transfer cancellation is pending.
    /// </summary>
    public required TransferCancellationPendingStatus1 Pending { get; init; } 
    /// <summary>
    /// Party that initiates the status.
    /// </summary>
    public PartyIdentification2Choice_? StatusInitiator { get; init; } 
    
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
        if (MasterReference is IsoMax35Text MasterReferenceValue)
        {
            writer.WriteStartElement(null, "MstrRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MasterReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TrfRef", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(TransferReference)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (ClientReference is IsoMax35Text ClientReferenceValue)
        {
            writer.WriteStartElement(null, "ClntRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ClientReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CancellationReference is IsoMax35Text CancellationReferenceValue)
        {
            writer.WriteStartElement(null, "CxlRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CancellationReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Sts", xmlNamespace );
        Status.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Rjctd", xmlNamespace );
        Rejected.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Cmplt", xmlNamespace );
        Complete.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Pdg", xmlNamespace );
        Pending.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (StatusInitiator is PartyIdentification2Choice_ StatusInitiatorValue)
        {
            writer.WriteStartElement(null, "StsInitr", xmlNamespace );
            StatusInitiatorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CancellationStatusAndReason2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
