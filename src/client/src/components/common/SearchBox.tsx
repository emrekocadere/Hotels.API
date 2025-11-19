interface SearchBoxProps {
  onSearch?: (data: SearchData) => void;
}

export interface SearchData {
  destination: string;
  checkIn: string;
  checkOut: string;
  guests: number;
}

const SearchBox = ({ onSearch }: SearchBoxProps) => {
  const handleSubmit = (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    const formData = new FormData(e.currentTarget);
    const data: SearchData = {
      destination: formData.get('destination') as string,
      checkIn: formData.get('checkIn') as string,
      checkOut: formData.get('checkOut') as string,
      guests: Number(formData.get('guests')),
    };
    onSearch?.(data);
  };

  return (
    <div className="max-w-4xl mx-auto bg-white rounded-xl shadow-lg p-6">
      <form onSubmit={handleSubmit}>
        <div className="grid md:grid-cols-4 gap-4">
          <div className="md:col-span-1">
            <label className="block text-sm font-medium text-slate-700 mb-2 text-left">Destination</label>
            <input
              type="text"
              name="destination"
              placeholder="Where are you going?"
              className="w-full px-4 py-3 border border-slate-300 rounded-lg focus:ring-2 focus:ring-blue-500 focus:border-transparent text-slate-900"
              required
            />
          </div>
          <div>
            <label className="block text-sm font-medium text-slate-700 mb-2 text-left">Check-in</label>
            <input
              type="date"
              name="checkIn"
              className="w-full px-4 py-3 border border-slate-300 rounded-lg focus:ring-2 focus:ring-blue-500 focus:border-transparent text-slate-900"
              required
            />
          </div>
          <div>
            <label className="block text-sm font-medium text-slate-700 mb-2 text-left">Check-out</label>
            <input
              type="date"
              name="checkOut"
              className="w-full px-4 py-3 border border-slate-300 rounded-lg focus:ring-2 focus:ring-blue-500 focus:border-transparent text-slate-900"
              required
            />
          </div>
          <div>
            <label className="block text-sm font-medium text-slate-700 mb-2 text-left">Guests</label>
            <select 
              name="guests"
              className="w-full px-4 py-3 border border-slate-300 rounded-lg focus:ring-2 focus:ring-blue-500 focus:border-transparent text-slate-900"
            >
              <option value="1">1 Guest</option>
              <option value="2">2 Guests</option>
              <option value="3">3 Guests</option>
              <option value="4">4 Guests</option>
              <option value="5">5+ Guests</option>
            </select>
          </div>
        </div>
        <button 
          type="submit"
          className="w-full md:w-auto mt-4 bg-blue-500 text-white px-8 py-3 rounded-lg text-lg font-semibold hover:bg-blue-600 transition-all shadow-md hover:shadow-lg"
        >
          Search Hotels
        </button>
      </form>
    </div>
  );
};

export default SearchBox;
