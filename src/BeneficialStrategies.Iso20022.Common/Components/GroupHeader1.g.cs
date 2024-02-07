﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GroupHeader1.  ISO2002 ID# _PvMh4tp-Ed-ak6NoX_4Aeg_-279444335.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics shared by all individual transactions included in the message.
/// </summary>
public partial record GroupHeader1
     : IIsoXmlSerilizable<GroupHeader1>
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference assigned by the instructing party and sent to the next party in the chain to unambiguously identify the message.||Usage: The instructing party has to make sure that 'MessageIdentification' is unique per instructed party for a pre-agreed period.
    /// </summary>
    public required IsoMax35Text MessageIdentification { get; init; } 
    /// <summary>
    /// Date and time at which a (group of) payment instruction(s) was created by the instructing party.
    /// </summary>
    public required IsoISODateTime CreationDateTime { get; init; } 
    /// <summary>
    /// User identification or any user key that allows to check if the initiating party is allowed to initiate transactions from the account specified in the initiation.||Usage: the content is not of a technical nature, but reflects the organisational structure at the initiating side. The authorisation element can typically be used in relay scenarios, payment initiations, payment returns or payment reversals that are initiated on behalf of a different party than the initiating party.
    /// </summary>
    public SimpleValueList<IsoMax128Text> Authorisation { get; init; } = [];
    /// <summary>
    /// Identifies whether a single entry per individual transaction or a batch entry for the sum of the amounts of all transactions in the message is requested.
    /// </summary>
    public IsoBatchBookingIndicator? BatchBooking { get; init; } 
    /// <summary>
    /// Number of individual transactions contained in the message.
    /// </summary>
    public required IsoMax15NumericText NumberOfTransactions { get; init; } 
    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies.
    /// </summary>
    public IsoDecimalNumber? ControlSum { get; init; } 
    /// <summary>
    /// Indicates whether common accounting information in the transaction is included once for all transactions or repeated for each single transaction.
    /// </summary>
    public required Grouping1Code Grouping { get; init; } 
    /// <summary>
    /// Party initiating the payment. In the payment context, this can either be the debtor (in a credit transfer), the creditor (in a direct debit), or the party that initiates the payment on behalf of the debtor or creditor.
    /// </summary>
    public required PartyIdentification8 InitiatingParty { get; init; } 
    /// <summary>
    /// Financial institution that receives the instruction from the initiating party and forwards it to the next agent in the payment chain for execution.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification3? ForwardingAgent { get; init; } 
    
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
        writer.WriteStartElement(null, "MsgId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(MessageIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CreDtTm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(CreationDateTime)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Authstn", xmlNamespace );
        Authorisation.Serialize(writer, xmlNamespace, "Max128Text", SerializationFormatter.IsoMax128Text );
        writer.WriteEndElement();
        if (BatchBooking is IsoBatchBookingIndicator BatchBookingValue)
        {
            writer.WriteStartElement(null, "BtchBookg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoBatchBookingIndicator(BatchBookingValue)); // data type BatchBookingIndicator System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "NbOfTxs", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax15NumericText(NumberOfTransactions)); // data type Max15NumericText System.String
        writer.WriteEndElement();
        if (ControlSum is IsoDecimalNumber ControlSumValue)
        {
            writer.WriteStartElement(null, "CtrlSum", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoDecimalNumber(ControlSumValue)); // data type DecimalNumber System.UInt64
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Grpg", xmlNamespace );
        writer.WriteValue(Grouping.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "InitgPty", xmlNamespace );
        InitiatingParty.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ForwardingAgent is BranchAndFinancialInstitutionIdentification3 ForwardingAgentValue)
        {
            writer.WriteStartElement(null, "FwdgAgt", xmlNamespace );
            ForwardingAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static GroupHeader1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
