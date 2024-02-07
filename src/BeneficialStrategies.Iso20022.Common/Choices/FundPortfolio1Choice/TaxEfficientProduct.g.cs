﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TaxEfficientProduct.  ISO2002 ID# _ibqr0U4HEeiQHa-q1Uephw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.FundPortfolio1Choice;

/// <summary>
/// Portfolio is a government scheme to encourage investment in securities based unit and investment trusts, offering certain tax benefits. These are not investments in their own right but are tax exempt 'wrappers' in which equities, bonds and funds can be held to shelter them from various types of tax.
/// In the UK, a typical tax wrapper product is known as an 'ISA' (Individual Savings Account).
/// </summary>
public partial record TaxEfficientProduct : FundPortfolio1Choice_
     , IIsoXmlSerilizable<TaxEfficientProduct>
{
    #nullable enable
    
    /// <summary>
    /// Type of tax efficient product, for example, an individual savings account (ISA) in the UK.
    /// </summary>
    public required TaxEfficientProductType1Choice_ TaxEfficientProductType { get; init; } 
    /// <summary>
    /// Investment plans issued during previous years.
    /// </summary>
    public PreviousYear2Choice_? PreviousYears { get; init; } 
    /// <summary>
    /// Indicates that the product was issued during the current fiscal year.
    /// </summary>
    public IsoYesNoIndicator? CurrentYear { get; init; } 
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
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "TaxEffcntPdctTp", xmlNamespace );
        TaxEfficientProductType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (PreviousYears is PreviousYear2Choice_ PreviousYearsValue)
        {
            writer.WriteStartElement(null, "PrvsYrs", xmlNamespace );
            PreviousYearsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CurrentYear is IsoYesNoIndicator CurrentYearValue)
        {
            writer.WriteStartElement(null, "CurYr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(CurrentYearValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (AdditionalInformation is AdditionalInformation15 AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            AdditionalInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new TaxEfficientProduct Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
