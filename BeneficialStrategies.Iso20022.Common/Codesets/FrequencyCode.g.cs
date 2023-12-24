﻿

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regularity of an event.
/// </summary>
[Serializable]
[IsoId("_asTIqdp-Ed-ak6NoX_4Aeg_-2101415313")]
[Description(@"Specifies the regularity of an event.")]
public enum FrequencyCode
{


    /// <summary>
    /// Event takes place every year or once a year.
    /// </summary>
    [IsoId("_ascSkNp-Ed-ak6NoX_4Aeg_1955128933")]
    [Description(@"Event takes place every year or once a year.")]
    YEAR,


    /// <summary>
    /// Event takes place every month or once a month.
    /// </summary>
    [IsoId("_ascSkdp-Ed-ak6NoX_4Aeg_-1999057333")]
    [Description(@"Event takes place every month or once a month.")]
    MNTH,


    /// <summary>
    /// Event takes place every three months or four times a year.
    /// </summary>
    [IsoId("_ascSktp-Ed-ak6NoX_4Aeg_-1972278110")]
    [Description(@"Event takes place every three months or four times a year.")]
    QURT,


    /// <summary>
    /// Event takes place every six months or two times a year.
    /// </summary>
    [IsoId("_ascSk9p-Ed-ak6NoX_4Aeg_-1941802024")]
    [Description(@"Event takes place every six months or two times a year.")]
    MIAN,


    /// <summary>
    /// Event takes place once a week.
    /// </summary>
    [IsoId("_ascSlNp-Ed-ak6NoX_4Aeg_-1913171921")]
    [Description(@"Event takes place once a week.")]
    WEEK,


    /// <summary>
    /// Event takes place every day.
    /// </summary>
    [IsoId("_ascSldp-Ed-ak6NoX_4Aeg_-1541103412")]
    [Description(@"Event takes place every day.")]
    DAIL,


    /// <summary>
    /// Event takes place on request or as necessary.
    /// </summary>
    [IsoId("_ascSltp-Ed-ak6NoX_4Aeg_18718985")]
    [Description(@"Event takes place on request or as necessary.")]
    ADHO,


    /// <summary>
    /// Event takes place several times a day.
    /// </summary>
    [IsoId("_ascSl9p-Ed-ak6NoX_4Aeg_18718986")]
    [Description(@"Event takes place several times a day.")]
    INDA,


    /// <summary>
    /// Event takes place overnight.
    /// </summary>
    [IsoId("_ascSmNp-Ed-ak6NoX_4Aeg_1507193436")]
    [Description(@"Event takes place overnight.")]
    OVNG,


    /// <summary>
    /// Event takes place every ten business days.
    /// </summary>
    [IsoId("_ascSmdp-Ed-ak6NoX_4Aeg_-2122538311")]
    [Description(@"Event takes place every ten business days.")]
    TEND,


    /// <summary>
    /// Event takes place every two weeks.
    /// </summary>
    [IsoId("_t74UdFkyEeGeoaLUQk__nA_329470843")]
    [Description(@"Event takes place every two weeks.")]
    FRTN,


    /// <summary>
    /// Event takes place at the end of the day if there was a movement on the account, otherwise nothing is sent that day.
    /// </summary>
    [IsoId("_24tC4BztEeKjsOi3S79ecQ_349226249")]
    [Description(@"Event takes place at the end of the day if there was a movement on the account, otherwise nothing is sent that day.")]
    MOVE,


    /// <summary>
    /// Event does never take place.
    /// </summary>
    [IsoId("_bAnk4GoEEearR-CA7eRZXQ")]
    [Description(@"Event does never take place.")]
    NEVR,


    /// <summary>
    /// Event takes place based on a change of a rate.
    /// </summary>
    [IsoId("_wrYBIGoEEearR-CA7eRZXQ")]
    [Description(@"Event takes place based on a change of a rate.")]
    RATE,


    /// <summary>
    /// Event occurs due to a credit event occurring for an issuer.
    /// </summary>
    [IsoId("_pL-KAMhvEeadgvwNGwK05w")]
    [Description(@"Event occurs due to a credit event occurring for an issuer.")]
    CRED,


    /// <summary>
    /// Event that takes place at the initiation of a trade or agreement.
    /// </summary>
    [IsoId("_sHTSsMhvEeadgvwNGwK05w")]
    [Description(@"Event that takes place at the initiation of a trade or agreement.")]
    UPFR,


    /// <summary>
    /// Event occurs on expiry of a financial contract.
    /// </summary>
    [IsoId("_yICGEMhvEeadgvwNGwK05w")]
    [Description(@"Event occurs on expiry of a financial contract.")]
    EXPI,


    /// <summary>
    /// Event takes place every hours.
    /// </summary>
    [IsoId("_--514IcEEeu4rpsqTt37Pg")]
    [Description(@"Event takes place every hours.")]
    HOUL,


    /// <summary>
    /// Event takes place every four months or three times a year.
    /// </summary>
    [IsoId("_MH1EENW3EeyVKLlq2-NhyA")]
    [Description(@"Event takes place every four months or three times a year.")]
    TRIL,


    /// <summary>
    /// Event takes place every two months or six times a year.
    /// </summary>
    [IsoId("_MaBAQNW3EeyVKLlq2-NhyA")]
    [Description(@"Event takes place every two months or six times a year.")]
    BIMN,


    /// <summary>
    /// Event takes place on demand.
    /// </summary>
    [IsoId("_13-sAMlPEeuJ35KoBRZFOg")]
    [Description(@"Event takes place on demand.")]
    ODMD,


    /// <summary>
    /// Event associated with a shift.
    /// </summary>
    [IsoId("_PBtwkMlQEeuJ35KoBRZFOg")]
    [Description(@"Event associated with a shift.")]
    SHFT,


    /// <summary>
    /// Two times a week
    /// </summary>
    [IsoId("_Ss5qMB1VEey8XKHwKquEQw")]
    [Description(@"Two times a week")]
    TWWK,

}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FrequencyCodeMetadataExtensions
{
    private static readonly FrequencyCodeDropdownSource _dropdownSource = new FrequencyCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFrequencyCodeDropdownRow GetMetadata(this FrequencyCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



/// <summary>
/// The values that should be expected from a single row of dropdown data.
/// </summary>
public partial interface IFrequencyCodeDropdownRow : IEnumMetadataDropdownRow<FrequencyCode>
{
}


/// <summary>
/// Default implementation of <seealso cref="IFrequencyCodeDropdownRow"/> that contains metadata embedded in the code.
/// </summary>
public partial class FrequencyCodeDropdownRow : EnumMetadataItem<FrequencyCode>, IFrequencyCodeDropdownRow
{
    /// <summary>
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FrequencyCodeDropdownRow(FrequencyCode value, MemberInfo memberInfo) : base( value, memberInfo)
    {
    }
}


/// <summary>
/// Used to inject dependencies that require dropdown choice values.
/// Understood to be uniquely a source of choices appropriate for a valid <seealso cref="FrequencyCode"/>.
/// </summary>
public partial interface IFrequencyCodeDropdownSource : IDropdownDataSource<IFrequencyCodeDropdownRow>
{
}


/// <summary>
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFrequencyCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
public partial class FrequencyCodeDropdownSource : EnumMetadataManager<FrequencyCode,IFrequencyCodeDropdownRow,FrequencyCodeDropdownRow>
{
    public FrequencyCodeDropdownSource()
        : base( (enumValue, memberInfo) => new FrequencyCodeDropdownRow(enumValue, memberInfo))
    {
    }
}

