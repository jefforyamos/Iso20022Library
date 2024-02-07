﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TaxEfficientProduct3.  ISO2002 ID# _jwT6wU7cEeifNrXGwadPmg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics of a tax efficient product.
/// </summary>
public partial record TaxEfficientProduct3
     : IIsoXmlSerilizable<TaxEfficientProduct3>
{
    #nullable enable
    
    /// <summary>
    /// Type of tax efficient product, for example, an individual savings account (ISA) in the UK.
    /// </summary>
    public required TaxEfficientProductType1Choice_ TaxEfficientProductType { get; init; } 
    /// <summary>
    /// Indicates whether the product contains a cash asset for transfer.
    /// </summary>
    public IsoYesNoIndicator? CashComponentIndicator { get; init; } 
    /// <summary>
    /// Investment plans issued during previous years.
    /// </summary>
    public PreviousYear4? PreviousYears { get; init; } 
    /// <summary>
    /// Amounts already subscribed for the current year.
    /// </summary>
    public SubscriptionInformation2? CurrentYearSubscriptionDetails { get; init; } 
    /// <summary>
    /// Additional information about the tax efficient product.
    /// </summary>
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    
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
        writer.WriteStartElement(null, "TaxEffcntPdctTp", xmlNamespace );
        TaxEfficientProductType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (CashComponentIndicator is IsoYesNoIndicator CashComponentIndicatorValue)
        {
            writer.WriteStartElement(null, "CshCmpntInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(CashComponentIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (PreviousYears is PreviousYear4 PreviousYearsValue)
        {
            writer.WriteStartElement(null, "PrvsYrs", xmlNamespace );
            PreviousYearsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CurrentYearSubscriptionDetails is SubscriptionInformation2 CurrentYearSubscriptionDetailsValue)
        {
            writer.WriteStartElement(null, "CurYrSbcptDtls", xmlNamespace );
            CurrentYearSubscriptionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalInformation is AdditionalInformation15 AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            AdditionalInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static TaxEfficientProduct3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
