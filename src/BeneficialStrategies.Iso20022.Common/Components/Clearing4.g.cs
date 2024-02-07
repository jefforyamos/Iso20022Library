﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Clearing4.  ISO2002 ID# _tv6MUWpUEeSgo9vJrfSF_Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the clearing details.
/// </summary>
public partial record Clearing4
     : IIsoXmlSerilizable<Clearing4>
{
    #nullable enable
    
    /// <summary>
    /// Indicates to the clearing member whether the trade is eligible for settlement netting or not.
    /// </summary>
    public required NettingEligible1Code SettlementNettingEligibleCode { get; init; } 
    /// <summary>
    /// Clearing organisation that will clear the trade.
    /// Note: This field allows clearing member firm to segregate flows coming from clearing counterparty's clearing system. Indeed, clearing member firms receive messages from the same system (same sender) and this field allows them to know if the message is related to equities or derivatives.
    /// </summary>
    public PartyIdentification35Choice_? ClearingSegment { get; init; } 
    /// <summary>
    /// Indicates if the position is guaranteed or non-guaranteed by the central counterparty, that is whether the CCP has done the novation and then guarantees the trade, or not.
    /// </summary>
    public IsoYesNoIndicator? GuaranteedTrade { get; init; } 
    /// <summary>
    /// In case of trades that are not guaranteed by the central counterparty (this is when the central counterparty has not done the novation), provides details such as the trade counterparty member identification or the trade counterparty clearing member identification.
    /// </summary>
    public NonGuaranteedTrade3? NonGuaranteedTrade { get; init; } 
    
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
        writer.WriteStartElement(null, "SttlmNetgElgblCd", xmlNamespace );
        writer.WriteValue(SettlementNettingEligibleCode.ToString()); // Enum value
        writer.WriteEndElement();
        if (ClearingSegment is PartyIdentification35Choice_ ClearingSegmentValue)
        {
            writer.WriteStartElement(null, "ClrSgmt", xmlNamespace );
            ClearingSegmentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (GuaranteedTrade is IsoYesNoIndicator GuaranteedTradeValue)
        {
            writer.WriteStartElement(null, "GrntedTrad", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(GuaranteedTradeValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (NonGuaranteedTrade is NonGuaranteedTrade3 NonGuaranteedTradeValue)
        {
            writer.WriteStartElement(null, "NonGrntedTrad", xmlNamespace );
            NonGuaranteedTradeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Clearing4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
