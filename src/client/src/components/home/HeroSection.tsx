import SearchBox, { type SearchData } from '@/components/common/SearchBox';

interface HeroSectionProps {
  onSearch: (data: SearchData) => void;
}

const HeroSection = ({ onSearch }: HeroSectionProps) => {
  return (
    <section className="bg-slate-700 text-white py-20 px-4">
      <div className="max-w-7xl mx-auto text-center">
        <h1 className="text-5xl font-bold mb-6">Find Your Perfect Stay</h1>
        <p className="text-xl text-slate-200 mb-8 max-w-2xl mx-auto">
          Discover amazing hotels around the world. Book your dream vacation with the best prices.
        </p>
        
        <SearchBox onSearch={onSearch} />
      </div>
    </section>
  );
};

export default HeroSection;
