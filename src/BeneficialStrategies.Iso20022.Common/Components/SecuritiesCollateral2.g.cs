﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesCollateral2.  ISO2002 ID# _H9e0cWA5EeSMf75YyPqG7w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the securities posted as collateral.
/// </summary>
public partial record SecuritiesCollateral2
     : IIsoXmlSerilizable<SecuritiesCollateral2>
{
    #nullable enable
    
    /// <summary>
    /// Identifies the register number of the collateral deposit assigned by the central counterparty.
    /// </summary>
    public IsoMax35Text? AssetNumber { get; init; } 
    /// <summary>
    /// Identification of a security.
    /// </summary>
    public required SecurityIdentification14 SecurityIdentification { get; init; } 
    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    public DateAndDateTimeChoice_? MaturityDate { get; init; } 
    /// <summary>
    /// Indicates whether the collateral is proprietarily owned or client owned.
    /// </summary>
    public CollateralOwnership1? CollateralOwnership { get; init; } 
    /// <summary>
    /// Indicates that the collateral posted in the clearing house covers the margin until a specific timeframe.
    /// </summary>
    public IsoYesNoIndicator? LimitedCoverageIndicator { get; init; } 
    /// <summary>
    /// Quantity of securities collateral.
    /// </summary>
    public required FinancialInstrumentQuantity1Choice_ Quantity { get; init; } 
    /// <summary>
    /// Quantity blocked by the central counterparty for any reasonable reason ( for example for judicial reasons). In this case the investor can not withdraw or distribute this collateral.
    /// </summary>
    public FinancialInstrumentQuantity1Choice_? BlockedQuantity { get; init; } 
    /// <summary>
    /// Indicates the price of the security.
    /// </summary>
    public Price2? Price { get; init; } 
    /// <summary>
    /// Value of the collateral based on current market prices.
    /// </summary>
    public IsoActiveCurrencyAndAmount? MarketValue { get; init; } 
    /// <summary>
    /// Haircut or valuation factor on the security expressed as a percentage.
    /// </summary>
    public IsoPercentageRate? Haircut { get; init; } 
    /// <summary>
    /// Value of the collateral after taking into account the haircut.
    /// </summary>
    public IsoActiveCurrencyAndAmount? CollateralValue { get; init; } 
    /// <summary>
    /// Valuation date of the securities taken as collateral.
    /// </summary>
    public IsoISODate? ValueDate { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public required SafekeepingPlaceFormat7Choice_ SafekeepingPlace { get; init; } 
    
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
        if (AssetNumber is IsoMax35Text AssetNumberValue)
        {
            writer.WriteStartElement(null, "AsstNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AssetNumberValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SctyId", xmlNamespace );
        SecurityIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (MaturityDate is DateAndDateTimeChoice_ MaturityDateValue)
        {
            writer.WriteStartElement(null, "MtrtyDt", xmlNamespace );
            MaturityDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CollateralOwnership is CollateralOwnership1 CollateralOwnershipValue)
        {
            writer.WriteStartElement(null, "CollOwnrsh", xmlNamespace );
            CollateralOwnershipValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LimitedCoverageIndicator is IsoYesNoIndicator LimitedCoverageIndicatorValue)
        {
            writer.WriteStartElement(null, "LtdCvrgInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(LimitedCoverageIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Qty", xmlNamespace );
        Quantity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (BlockedQuantity is FinancialInstrumentQuantity1Choice_ BlockedQuantityValue)
        {
            writer.WriteStartElement(null, "BlckdQty", xmlNamespace );
            BlockedQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Price is Price2 PriceValue)
        {
            writer.WriteStartElement(null, "Pric", xmlNamespace );
            PriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MarketValue is IsoActiveCurrencyAndAmount MarketValueValue)
        {
            writer.WriteStartElement(null, "MktVal", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(MarketValueValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (Haircut is IsoPercentageRate HaircutValue)
        {
            writer.WriteStartElement(null, "Hrcut", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(HaircutValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
        if (CollateralValue is IsoActiveCurrencyAndAmount CollateralValueValue)
        {
            writer.WriteStartElement(null, "CollVal", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(CollateralValueValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (ValueDate is IsoISODate ValueDateValue)
        {
            writer.WriteStartElement(null, "ValDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(ValueDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (SafekeepingAccount is SecuritiesAccount19 SafekeepingAccountValue)
        {
            writer.WriteStartElement(null, "SfkpgAcct", xmlNamespace );
            SafekeepingAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SfkpgPlc", xmlNamespace );
        SafekeepingPlace.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static SecuritiesCollateral2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
