namespace BlazorNestedDataFlow.Services
{
    public class GiftService
    {
        // A simple list of gifts
        private List<string> _gifts = new List<string>
    {
        "Iphone 16 pro max", "Samsung s24 ultra", "Samsung s24", "Iphone 16", "Samsung s23"
    };

        // Method to get all gifts
        public List<string> GetGifts()
        {
            return _gifts;
        }

        // Method to add a new gift
        public void AddGift(string gift)
        {
            _gifts.Add(gift);
        }

        // Method to remove a gift
        public void RemoveGift(string gift)
        {
            _gifts.Remove(gift);
        }
    }

}
