using System;
using Xunit;
using MarketDataModules.Models.Candles;
using Tinkoff.Trading.OpenApi.Models;
using DataCollector.TinkoffAdapter;

namespace DataCollector.Tests
{
    public class GetTinkoffDataTest
    {
        static int candleCount = 100;
        CandleList GetCandles(Tinkoff.Trading.OpenApi.Models.CandleInterval candleInterval)
        {
            return new GetTinkoffData().GetCandlesTinkoffAsync("BBG000BVPV84", candleInterval, candleCount).GetAwaiter().GetResult();
        }            

        [Fact]
        public void MinuteCandlesCount()
        {
            Assert.Equal(GetCandles(Tinkoff.Trading.OpenApi.Models.CandleInterval.Minute).Candles.Count, candleCount);
        }

        [Fact]
        public void TwoMinutesCandlesCount()
        {
            Assert.Equal(GetCandles(Tinkoff.Trading.OpenApi.Models.CandleInterval.TwoMinutes).Candles.Count, candleCount);
        }
        [Fact]
        public void ThreeMinutesCandlesCount()
        {
            Assert.Equal(GetCandles(Tinkoff.Trading.OpenApi.Models.CandleInterval.ThreeMinutes).Candles.Count, candleCount);
        }
        [Fact]
        public void FiveMinutesCandlesCount()
        {
            Assert.Equal(GetCandles(Tinkoff.Trading.OpenApi.Models.CandleInterval.FiveMinutes).Candles.Count, candleCount);
        }
        [Fact]
        public void TenMinutesCandlesCount()
        {
            Assert.Equal(GetCandles(Tinkoff.Trading.OpenApi.Models.CandleInterval.TenMinutes).Candles.Count, candleCount);
        }
        [Fact]
        public void QuarterHourCandlesCount()
        {
            Assert.Equal(GetCandles(Tinkoff.Trading.OpenApi.Models.CandleInterval.QuarterHour).Candles.Count, candleCount);
        }
        [Fact]
        public void HourCandlesCount()
        {
            Assert.Equal(GetCandles(Tinkoff.Trading.OpenApi.Models.CandleInterval.Hour).Candles.Count, candleCount);
        }
        [Fact]
        public void DayCandlesCount()
        {
            Assert.Equal(GetCandles(Tinkoff.Trading.OpenApi.Models.CandleInterval.Day).Candles.Count, candleCount);
        }
        [Fact]
        public void WeekCandlesCount()
        {
            Assert.Equal(GetCandles(Tinkoff.Trading.OpenApi.Models.CandleInterval.Week).Candles.Count, candleCount);
        }
        [Fact]
        public void MonthCandlesCount()
        {
            Assert.Equal(GetCandles(Tinkoff.Trading.OpenApi.Models.CandleInterval.Month).Candles.Count, candleCount);
        }

    }
}
