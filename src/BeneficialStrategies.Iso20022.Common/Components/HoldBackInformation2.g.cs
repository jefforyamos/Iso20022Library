﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for HoldBackInformation2.  ISO2002 ID# _i4Ff4TwvEeaFzejt0Yw_3A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about hold back and gating.
/// </summary>
public partial record HoldBackInformation2
     : IIsoXmlSerilizable<HoldBackInformation2>
{
    #nullable enable
    
    /// <summary>
    /// Type of gating or a hold back.
    /// </summary>
    public required GateHoldBack1Code Type { get; init; } 
    /// <summary>
    /// Value of the redemption amount subject to gating or a hold back.
    /// </summary>
    public IsoActiveCurrencyAndAmount? Amount { get; init; } 
    /// <summary>
    /// Date on which the gated amount or hold back amount is expected to be released.
    /// </summary>
    public IsoISODate? ExpectedReleaseDate { get; init; } 
    /// <summary>
    /// New identification of the security.
    /// </summary>
    public SecurityIdentification25Choice_? FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// New name of the security.
    /// </summary>
    public IsoMax350Text? FinancialInstrumentName { get; init; } 
    /// <summary>
    /// Specifies whether or not additional redemption order instructions are required in order for the redemption to be completed.
    /// </summary>
    public RedemptionCompletion1Code? RedemptionCompletion { get; init; } 
    /// <summary>
    /// Indicates whether or not this is the final redemption confirmation in the execution of a gated redemption.
    /// </summary>
    public IsoYesNoIndicator? FinalConfirmation { get; init; } 
    
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
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        writer.WriteValue(Type.ToString()); // Enum value
        writer.WriteEndElement();
        if (Amount is IsoActiveCurrencyAndAmount AmountValue)
        {
            writer.WriteStartElement(null, "Amt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(AmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (ExpectedReleaseDate is IsoISODate ExpectedReleaseDateValue)
        {
            writer.WriteStartElement(null, "XpctdRlsDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(ExpectedReleaseDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (FinancialInstrumentIdentification is SecurityIdentification25Choice_ FinancialInstrumentIdentificationValue)
        {
            writer.WriteStartElement(null, "FinInstrmId", xmlNamespace );
            FinancialInstrumentIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FinancialInstrumentName is IsoMax350Text FinancialInstrumentNameValue)
        {
            writer.WriteStartElement(null, "FinInstrmNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(FinancialInstrumentNameValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (RedemptionCompletion is RedemptionCompletion1Code RedemptionCompletionValue)
        {
            writer.WriteStartElement(null, "RedCmpltn", xmlNamespace );
            writer.WriteValue(RedemptionCompletionValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (FinalConfirmation is IsoYesNoIndicator FinalConfirmationValue)
        {
            writer.WriteStartElement(null, "FnlConf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(FinalConfirmationValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
    }
    public static HoldBackInformation2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
