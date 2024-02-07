﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TMSProtocolParameters5.  ISO2002 ID# _YotmsQufEeqw5uEXxQ9H4g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Configuration parameters of the TMS protocol between a POI and a terminal manager.
/// </summary>
public partial record TMSProtocolParameters5
     : IIsoXmlSerilizable<TMSProtocolParameters5>
{
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    public required TerminalManagementAction3Code ActionType { get; init; } 
    /// <summary>
    /// Identification of the master terminal manager or the terminal manager.
    /// </summary>
    public required GenericIdentification176 TerminalManagerIdentification { get; init; } 
    /// <summary>
    /// Protocol version to use when using these parameters.
    /// </summary>
    public IsoMax8Text? ProtocolVersion { get; init; } 
    /// <summary>
    /// Maintenance services provided by the terminal manager.
    /// </summary>
    public DataSetCategory10Code? MaintenanceService { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _Yz8mVwufEeqw5uEXxQ9H4g
    /// <summary>
    /// Version of the TMS protocol parameters.
    /// </summary>
    public required IsoMax256Text Version { get; init; } 
    /// <summary>
    /// Identification of applications which may be managed by the TM, partially or globally.
    /// </summary>
    public IsoMax35Text? ApplicationIdentification { get; init; } 
    /// <summary>
    /// Identification of the terminal manager host.
    /// </summary>
    public required IsoMax35Text HostIdentification { get; init; } 
    /// <summary>
    /// New identification of the POI for the terminal manager.
    /// </summary>
    public IsoMax35Text? POIIdentification { get; init; } 
    /// <summary>
    /// New identification of the initiating party to set in TMS messages with this terminal manager.
    /// </summary>
    public IsoMax35Text? InitiatingPartyIdentification { get; init; } 
    /// <summary>
    /// New identification of the recipient party to set in TMS messages with this terminal manager.
    /// </summary>
    public IsoMax35Text? RecipientPartyIdentification { get; init; } 
    /// <summary>
    /// Configuration parameters are exchanged per file transfer protocol rather than per message.
    /// </summary>
    public IsoTrueFalseIndicator? FileTransfer { get; init; } 
    /// <summary>
    /// Configuration of a message item.
    /// </summary>
    public MessageItemCondition1? MessageItem { get; init; } 
    
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
        writer.WriteStartElement(null, "ActnTp", xmlNamespace );
        writer.WriteValue(ActionType.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TermnlMgrId", xmlNamespace );
        TerminalManagerIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ProtocolVersion is IsoMax8Text ProtocolVersionValue)
        {
            writer.WriteStartElement(null, "PrtcolVrsn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax8Text(ProtocolVersionValue)); // data type Max8Text System.String
            writer.WriteEndElement();
        }
        // Not sure how to serialize MaintenanceService, multiplicity Unknown
        writer.WriteStartElement(null, "Vrsn", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax256Text(Version)); // data type Max256Text System.String
        writer.WriteEndElement();
        if (ApplicationIdentification is IsoMax35Text ApplicationIdentificationValue)
        {
            writer.WriteStartElement(null, "ApplId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ApplicationIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "HstId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(HostIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (POIIdentification is IsoMax35Text POIIdentificationValue)
        {
            writer.WriteStartElement(null, "POIId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(POIIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (InitiatingPartyIdentification is IsoMax35Text InitiatingPartyIdentificationValue)
        {
            writer.WriteStartElement(null, "InitgPtyId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(InitiatingPartyIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (RecipientPartyIdentification is IsoMax35Text RecipientPartyIdentificationValue)
        {
            writer.WriteStartElement(null, "RcptPtyId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(RecipientPartyIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (FileTransfer is IsoTrueFalseIndicator FileTransferValue)
        {
            writer.WriteStartElement(null, "FileTrf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(FileTransferValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (MessageItem is MessageItemCondition1 MessageItemValue)
        {
            writer.WriteStartElement(null, "MsgItm", xmlNamespace );
            MessageItemValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static TMSProtocolParameters5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
