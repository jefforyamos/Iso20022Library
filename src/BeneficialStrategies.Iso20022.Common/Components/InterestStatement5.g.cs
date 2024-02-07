﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InterestStatement5.  ISO2002 ID# _WxUNESqWEeyR9JrVGfaMKw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the interest statement.
/// </summary>
public partial record InterestStatement5
     : IIsoXmlSerilizable<InterestStatement5>
{
    #nullable enable
    
    /// <summary>
    /// Provides the period during which the interest rate has been applied.
    /// </summary>
    public required DatePeriod2 InterestPeriod { get; init; } 
    /// <summary>
    /// Provides the total amount of interest that is due to partyA.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TotalInterestAmountDueToA { get; init; } 
    /// <summary>
    /// Provides the total amount of interest that is due to partyB.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TotalInterestAmountDueToB { get; init; } 
    /// <summary>
    /// Indicates the value date of the interest statement.
    /// </summary>
    public required IsoISODate ValueDate { get; init; } 
    /// <summary>
    /// Provides the reference to the interest payment request.
    /// </summary>
    public IsoMax35Text? InterestPaymentRequestIdentification { get; init; } 
    /// <summary>
    /// Provides the details of the interest calculation.
    /// </summary>
    public InterestCalculation5? InterestCalculation { get; init; } 
    
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
        writer.WriteStartElement(null, "IntrstPrd", xmlNamespace );
        InterestPeriod.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (TotalInterestAmountDueToA is IsoActiveCurrencyAndAmount TotalInterestAmountDueToAValue)
        {
            writer.WriteStartElement(null, "TtlIntrstAmtDueToA", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(TotalInterestAmountDueToAValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (TotalInterestAmountDueToB is IsoActiveCurrencyAndAmount TotalInterestAmountDueToBValue)
        {
            writer.WriteStartElement(null, "TtlIntrstAmtDueToB", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(TotalInterestAmountDueToBValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "ValDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(ValueDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        if (InterestPaymentRequestIdentification is IsoMax35Text InterestPaymentRequestIdentificationValue)
        {
            writer.WriteStartElement(null, "IntrstPmtReqId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(InterestPaymentRequestIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (InterestCalculation is InterestCalculation5 InterestCalculationValue)
        {
            writer.WriteStartElement(null, "IntrstClctn", xmlNamespace );
            InterestCalculationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static InterestStatement5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
