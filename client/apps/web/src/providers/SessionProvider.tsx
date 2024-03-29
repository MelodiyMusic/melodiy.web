import { createContext, useCallback, useEffect, useState } from 'react';
import { IContainer, User } from '@melodiy/types';
import { fetchUser, getApiError, login, logout, register } from '@melodiy/api';
import toast from 'react-hot-toast';
import { createRouter, useNavigate } from '@tanstack/react-router';
import { routeTree } from '../routeTree.gen';

type SessionContextType = {
  user?: User;
  isLoading: boolean;
  login: (username: string, password: string) => void;
  register: (username: string, password: string) => void;
  logout: () => void;
  // update: () => void;
};

export const SessionContext = createContext<SessionContextType>({
  user: undefined,
  isLoading: true,
  login: async () => Promise<void>,
  register: async () => Promise<void>,
  logout: async () => Promise<void>,
});

export default function SessionProvider({ children }: IContainer) {
  const [user, setUser] = useState<User>();
  const [loading, setLoading] = useState(true);
  const navigate = useNavigate();

  const getUser = useCallback(async () => {
    try {
      setLoading(true);
      const user = await fetchUser();
      setUser(user);
    } catch (err) {
      console.log(err);
    } finally {
      setLoading(false);
    }
  }, []);

  useEffect(() => {
    getUser();
  }, [getUser]);

  const handleLogin = useCallback(
    async (username: string, password: string) => {
      try {
        setLoading(true);
        const user = await login(username, password);

        toast.success('Succesfully created user');
        setUser({ id: user.id, username: user.username });
        return true;
      } catch (err) {
        toast.error(getApiError(err).message);
        return false;
      } finally {
        setLoading(false);
      }
    },
    []
  );

  const handleSignUp = useCallback(
    async (username: string, password: string) => {
      try {
        setLoading(true);
        const user = await register(username, password);

        toast.success('Successfully regisetered account');
        setUser({ id: user.id, username: user.username });
        return true;
      } catch (err) {
        toast.error(getApiError(err).message);
        return false;
      } finally {
        setLoading(false);
      }
    },
    []
  );

  const handleLogout = useCallback(async () => {
    try {
      await logout();
      toast.success('Logout successfull');
      setUser(undefined);
      navigate({ to: '/' });
    } catch (err) {
      toast.error(getApiError(err).message);
    }
  }, [navigate]);

  return (
    <SessionContext.Provider
      value={{
        user,
        login: handleLogin,
        register: handleSignUp,
        logout: handleLogout,
        isLoading: loading,
      }}
    >
      {children}
    </SessionContext.Provider>
  );
}
