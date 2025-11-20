interface DestinationCardProps {
  city: string;
}

const DestinationCard = ({ city }: DestinationCardProps) => {
  return (
    <div 
      className="relative h-64 rounded-xl overflow-hidden shadow-lg hover:shadow-xl transition-shadow cursor-pointer group"
    >
      <div className="absolute inset-0 bg-gradient-to-t from-slate-900 to-transparent z-10"></div>
      <div className="absolute inset-0 bg-slate-300"></div>
      <div className="absolute bottom-0 left-0 right-0 p-6 z-20">
        <h3 className="text-2xl font-bold text-white mb-2">{city}</h3>
        <p className="text-slate-200 text-sm">Explore hotels</p>
      </div>
    </div>
  );
};

const destinations = ['Paris', 'Tokyo', 'New York', 'Dubai'];

const PopularDestinationsSection = () => {
  return (
    <section className="py-16 px-4">
      <div className="max-w-7xl mx-auto">
        <h2 className="text-3xl font-bold text-slate-900 text-center mb-12">Popular Destinations</h2>
        <div className="grid md:grid-cols-4 gap-6">
          {destinations.map((city) => (
            <DestinationCard key={city} city={city} />
          ))}
        </div>
      </div>
    </section>
  );
};

export default PopularDestinationsSection;
