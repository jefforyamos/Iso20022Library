﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Plan2.  ISO2002 ID# _0uO7YZJJEeuuktRxxQZoNQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Attributes of the instalment plan.
/// </summary>
public partial record Plan2
     : IIsoXmlSerilizable<Plan2>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the instalment plan.
    /// </summary>
    public IsoMax70Text? PlanIdentification { get; init; } 
    /// <summary>
    /// List of plan owners.
    /// </summary>
    public PlanOwner1Code? PlanOwner { get; init; } 
    /// <summary>
    /// Other plan owner, used when PlanOwner is OtherNational or OtherPrivate.
    /// </summary>
    public IsoMax35Text? OtherPlanOwner { get; init; } 
    /// <summary>
    /// Instalment payment type.
    /// </summary>
    public IsoMax35Text? InstalmentPaymentType { get; init; } 
    /// <summary>
    /// Indicate a deferred Instalment plan.
    /// </summary>
    public IsoTrueFalseIndicator? DeferredInstalmentIndicator { get; init; } 
    /// <summary>
    /// Period unit between consecutive payments.
    /// </summary>
    public Frequency18Code? PeriodUnit { get; init; } 
    /// <summary>
    /// Number of period units between consecutive payments.
    /// </summary>
    public IsoNumber? NumberOfPeriods { get; init; } 
    /// <summary>
    /// Details of the interest rate.
    /// </summary>
    public InterestRateDetails2? InterestRate { get; init; } 
    /// <summary>
    /// Date of the first payment.
    /// </summary>
    public IsoISODate? FirstPaymentDate { get; init; } 
    /// <summary>
    /// Amount of the first payment when different from the subsequent payments.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? FirstAmount { get; init; } 
    /// <summary>
    /// Normal payment amount.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? NormalPaymentAmount { get; init; } 
    /// <summary>
    /// Total number of instalment payments.
    /// </summary>
    public IsoNumber? TotalNumberOfPayments { get; init; } 
    /// <summary>
    /// Currency code associated with the instalment amount.  ISO 4217 "Codes for the representation of currencies and funds".
    /// </summary>
    public ISO3NumericCurrencyCode? InstalmentCurrency { get; init; } 
    /// <summary>
    /// Contains grace period details.
    /// </summary>
    public GracePeriod2? GracePeriod { get; init; } 
    /// <summary>
    /// Contains the amount details of an instalment plan.
    /// </summary>
    public InstalmentAmountDetails2? AmountDetails { get; init; } 
    /// <summary>
    /// Total amount of the instalment including charges, insurance and taxes in addition to the funded amount.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? GrandTotalAmount { get; init; } 
    /// <summary>
    /// Additional plan data
    /// </summary>
    public AdditionalData1? AdditionalData { get; init; } 
    
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
        if (PlanIdentification is IsoMax70Text PlanIdentificationValue)
        {
            writer.WriteStartElement(null, "PlanId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(PlanIdentificationValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (PlanOwner is PlanOwner1Code PlanOwnerValue)
        {
            writer.WriteStartElement(null, "PlanOwnr", xmlNamespace );
            writer.WriteValue(PlanOwnerValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (OtherPlanOwner is IsoMax35Text OtherPlanOwnerValue)
        {
            writer.WriteStartElement(null, "OthrPlanOwnr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OtherPlanOwnerValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (InstalmentPaymentType is IsoMax35Text InstalmentPaymentTypeValue)
        {
            writer.WriteStartElement(null, "InstlmtPmtTp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(InstalmentPaymentTypeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (DeferredInstalmentIndicator is IsoTrueFalseIndicator DeferredInstalmentIndicatorValue)
        {
            writer.WriteStartElement(null, "DfrrdInstlmtInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(DeferredInstalmentIndicatorValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (PeriodUnit is Frequency18Code PeriodUnitValue)
        {
            writer.WriteStartElement(null, "PrdUnit", xmlNamespace );
            writer.WriteValue(PeriodUnitValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (NumberOfPeriods is IsoNumber NumberOfPeriodsValue)
        {
            writer.WriteStartElement(null, "NbOfPrds", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(NumberOfPeriodsValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        if (InterestRate is InterestRateDetails2 InterestRateValue)
        {
            writer.WriteStartElement(null, "IntrstRate", xmlNamespace );
            InterestRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FirstPaymentDate is IsoISODate FirstPaymentDateValue)
        {
            writer.WriteStartElement(null, "FrstPmtDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(FirstPaymentDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (FirstAmount is IsoImpliedCurrencyAndAmount FirstAmountValue)
        {
            writer.WriteStartElement(null, "FrstAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(FirstAmountValue)); // data type ImpliedCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (NormalPaymentAmount is IsoImpliedCurrencyAndAmount NormalPaymentAmountValue)
        {
            writer.WriteStartElement(null, "NrmlPmtAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(NormalPaymentAmountValue)); // data type ImpliedCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (TotalNumberOfPayments is IsoNumber TotalNumberOfPaymentsValue)
        {
            writer.WriteStartElement(null, "TtlNbOfPmts", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(TotalNumberOfPaymentsValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        if (InstalmentCurrency is ISO3NumericCurrencyCode InstalmentCurrencyValue)
        {
            writer.WriteStartElement(null, "InstlmtCcy", xmlNamespace );
            writer.WriteValue(InstalmentCurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (GracePeriod is GracePeriod2 GracePeriodValue)
        {
            writer.WriteStartElement(null, "GracePrd", xmlNamespace );
            GracePeriodValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AmountDetails is InstalmentAmountDetails2 AmountDetailsValue)
        {
            writer.WriteStartElement(null, "AmtDtls", xmlNamespace );
            AmountDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (GrandTotalAmount is IsoImpliedCurrencyAndAmount GrandTotalAmountValue)
        {
            writer.WriteStartElement(null, "GrdTtlAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(GrandTotalAmountValue)); // data type ImpliedCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (AdditionalData is AdditionalData1 AdditionalDataValue)
        {
            writer.WriteStartElement(null, "AddtlData", xmlNamespace );
            AdditionalDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Plan2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
