import { type SearchData } from '@/components/common/SearchBox';
import HeroSection from '@/components/home/HeroSection';
import FeaturesSection from '@/components/home/FeaturesSection';
import StatsSection from '@/components/home/StatsSection';
import PopularDestinationsSection from '@/components/home/PopularDestinationsSection';
import CTASection from '@/components/home/CTASection';
import TestimonialsSection from '@/components/home/TestimonialsSection';

const HomePage = () => {
  const handleSearch = (data: SearchData) => {
    console.log('Search data:', data);
    // TODO: Implement search functionality
  };

  return (
    <div className="min-h-screen bg-slate-50">
      <HeroSection onSearch={handleSearch} />
      <FeaturesSection />
      <StatsSection />
      <PopularDestinationsSection />
      <CTASection />
      <TestimonialsSection />
    </div>
  );
};

export default HomePage;
