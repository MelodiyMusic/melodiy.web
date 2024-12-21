import { IconProps } from '../types';
import { twMerge } from 'tailwind-merge';

function LikeIcon({ width = 50, height = 50, className }: Partial<IconProps>) {
  return (
    <svg xmlns="http://www.w3.org/2000/svg"
    width={width}
    height={height}
    className={twMerge('text-base-accent stroke-current', className)}
    fill="none"
    viewBox="0 0 41 42" >
      <path stroke="stroke-current" stroke-linecap="round" stroke-linejoin="round" stroke-width="2.021" d="m22.74 14.492-1.864 1.806-1.864-1.806a4.807 4.807 0 0 0-6.914.23c-1.77 1.96-2.013 4.896-.41 6.995.196.258.39.505.574.73 1.167 1.432 3.712 3.93 4.987 5.272.942.99 1.789 1.817 2.427 2.419a1.736 1.736 0 0 0 2.389-.013c1.176-1.105 2.98-2.827 4.25-4.163 1.276-1.341 2.007-2.083 3.174-3.514.184-.226.378-.473.575-.731 1.602-2.099 1.359-5.034-.411-6.994a4.808 4.808 0 0 0-6.913-.23Z"></path>
    </svg>
  );
}

export { LikeIcon };
